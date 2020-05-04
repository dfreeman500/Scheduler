using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using web.Data;
using web.Models;

namespace web.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly Context _context;

        public AppointmentController(Context context)
        {
            _context = context;
        }

        // GET: Appointment
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;

            ViewData["RequestedTimeSortParm"] = String.IsNullOrEmpty(sortOrder) ? "RequestedTime_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "Name" ? "Name_desc" : "Name";
            ViewData["EmployeeSortParm"] = sortOrder == "Employee" ? "Employee_desc" : "Employee";
            ViewData["AppointmentNotesSortParm"] = sortOrder == "AppointmentNotes" ? "AppointmentNotes_desc" : "AppointmentNotes";
            ViewData["PhoneNumberSortParm"] = sortOrder == "PhoneNumber" ? "PhoneNumber_desc" : "PhoneNumber";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var appointments = from s in _context.Appointments.Include(a => a.Employee) select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                appointments = appointments.Include(a => a.Employee)
                .Where(s => s.Name.Contains(searchString)
                 || s.PhoneNumber.Contains(searchString)
                 || s.AppointmentNotes.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "Name_desc":
                    appointments = appointments.OrderByDescending(x => x.Name);
                    break;
                case "Name":
                    appointments = appointments.OrderBy(x => x.Name);
                    break;
                case "PhoneNumber_desc":
                    appointments = appointments.OrderByDescending(x => x.PhoneNumber);
                    break;
                case "PhoneNumber":
                    appointments = appointments.OrderBy(x => x.PhoneNumber);
                    break;
                case "AppointmentNotes_desc":
                    appointments = appointments.OrderByDescending(x => x.AppointmentNotes);
                    break;
                case "AppointmentNotes":
                    appointments = appointments.OrderBy(x => x.AppointmentNotes);
                    break;
                case "Employee_desc":
                    appointments = appointments.OrderByDescending(x => x.Employee);
                    break;
                case "Employee":
                    appointments = appointments.OrderBy(x => x.Employee);
                    break;
                case "RequestedTime_desc":
                    appointments = appointments.OrderByDescending(x => x.RequestedTime);
                    break;
                default:
                    appointments = appointments.OrderBy(x => x.RequestedTime);
                    break;
            }





            int pageSize = 100;
            return View(await PaginatedList<Appointment>.CreateAsync(appointments.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Appointment/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointment/Create
        // public IActionResult Create()
        // {
        //     ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName");
        //     return View();
        // }
        // [HttpPost]
        public IActionResult Create(Guid id, DateTime time)
        {
            ViewBag.ListOfEmployees = _context.Employees.ToList();
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName");
            return View(new Appointment { RequestedTime = time, EmployeeId = id });

        }

        // POST: Appointment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,PhoneNumber,AppointmentNotes,EmployeeId,RequestedTime,Id")] Appointment appointment)
        {
            //Gives info to modelState addModelError - allows for determining out range and double booking requests
            var employee = _context.Employees.Find(appointment.EmployeeId);

            //Determines that RequestedTime is within time range for employee
            bool isWithin = (appointment.RequestedTime.TimeOfDay > employee.StartTime.TimeOfDay || appointment.RequestedTime.TimeOfDay == employee.StartTime.TimeOfDay) && (appointment.RequestedTime.TimeOfDay < employee.EndTime.TimeOfDay || appointment.RequestedTime.TimeOfDay == employee.EndTime.TimeOfDay);

            //Raise an error if requested time is outside of employee's working window
            if (isWithin == false)
            {
                ModelState.AddModelError("RequestedTime", employee.FullName + " only works between " + employee.StartTime.ToString("hh:mm tt") + " and " + employee.EndTime.ToString("hh:mm tt"));
            }

            //Searches for another appointment with the same time and employee (ie.for double booking event)
            var doubleBookings = _context.Appointments
                .Where(st => st.RequestedTime == appointment.RequestedTime)
                .Where(st => st.EmployeeId == appointment.EmployeeId)
                .FirstOrDefault();

            //makes a list of all available employees at the time someone is making an appointment
            var listOfEmployees = _context.Employees.Select(x => x.FullName).ToList();

            //Finds appointments across all employees with overlapping times
            var appointmentsWithOverlappingTimes = _context.Appointments
                .Where(aw => aw.RequestedTime == appointment.RequestedTime)
                .ToList();



            //Finds employees where the appointment would be outside of work window
            var listOfEmployeesOutsideWindow = _context.Employees
            .Where(x => x.StartTime.TimeOfDay > appointment.RequestedTime.TimeOfDay || x.EndTime.TimeOfDay < appointment.RequestedTime.TimeOfDay)
            .ToList();


            //removes employee names from listOfEmployees when the appointment is outside work window
            foreach (var emp in listOfEmployeesOutsideWindow)
            {
                listOfEmployees.Remove(emp.FullName);
            }

            //removes employee name from listOfEmployees when that employee has an overlapping time - results in only available employees being shown
            foreach (var emp in appointmentsWithOverlappingTimes)
            {
                listOfEmployees.Remove(emp.Employee.FullName);
            }

            //raise error if doubleBookings found an entry
            if (doubleBookings != null)
            {
                ModelState.AddModelError("RequestedTime", employee.FullName + " already has somone scheduled at that time. Other employees available: " + listOfEmployees.Count + " | " + string.Join(", ", listOfEmployees));
            }

            if (ModelState.IsValid)
            {
                appointment.Id = Guid.NewGuid();
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName", appointment.EmployeeId);
            return View(appointment);
        }

        // GET: Appointment/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName", appointment.EmployeeId);
            return View(appointment);
        }

        // POST: Appointment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Name,PhoneNumber,AppointmentNotes,EmployeeId,RequestedTime,Id")] Appointment appointment)
        {
            //Searches for other appointments with the same time and employee (ie.for double booking events)
            // var isDoubleBooked = _context.Appointments
            //     .Where(st => st.RequestedTime == appointment.RequestedTime)
            //     .Where(st=> st.EmployeeId == appointment.EmployeeId)
            //     .SingleOrDefault();

            //             An unhandled exception occurred while processing the request.
            //             InvalidOperationException: The instance of entity type 'Appointment' cannot be tracked because another instance with the same key value for {'Id'} is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the conflicting key values.
            //             
            //             var copyOfId = appointment.Id; //so doesn't throw an error
            //             var entryBeforeEdit = _context.Appointments
            //                 .Where(eb => eb.Id == appointment.Id)
            //                 .SingleOrDefault();
            //              if(isDoubleBooked != null && entryBeforeEdit == null ) //if records are found, then requested time would double book the employee - raise an error

            // if(isDoubleBooked != null) //if records are found, then requested time would double book the employee - raise an error
            // {
            //     ModelState.AddModelError("RequestedTime", "The requested appointment overlaps with another appointment for this employee");
            // }


            if (id != appointment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName", appointment.EmployeeId);
            return View(appointment);
        }

        // GET: Appointment/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(Guid id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }
    }
}

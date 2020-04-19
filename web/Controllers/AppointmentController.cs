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
        public async Task<IActionResult> Index()
        {
            var context = _context.Appointments.Include(a => a.Employee);
            return View(await context.ToListAsync());
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
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName" ); 
            return View(new Appointment {RequestedTime=time, EmployeeId = id});

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
            bool isWithin = (appointment.RequestedTime.TimeOfDay > employee.StartTime.TimeOfDay || appointment.RequestedTime.TimeOfDay == employee.StartTime.TimeOfDay ) && (appointment.RequestedTime.TimeOfDay < employee.EndTime.TimeOfDay || appointment.RequestedTime.TimeOfDay == employee.EndTime.TimeOfDay );
            
            //Raise an error if requested time is outside of employee's working window
            if(isWithin == false) 
            {
                ModelState.AddModelError("RequestedTime", employee.FullName + " only works between " + employee.StartTime.ToString("hh:mm tt") + " and " + employee.EndTime.ToString("hh:mm tt"));
            }

           //Searches for another appointment with the same time and employee (ie.for double booking event)
            var doubleBookings = _context.Appointments
                .Where(st => st.RequestedTime == appointment.RequestedTime)
                .Where(st=> st.EmployeeId == appointment.EmployeeId)
                .SingleOrDefault();
                      
            //makes a list of all available employees at the time someone is making an appointment
            var listOfAllEmployees = _context.Employees.Select(x=>x.FullName).ToList();

            //Finds appointments across all employees with overlapping times
            var appointmentsWithOverlappingTimes = _context.Appointments 
                .Where(aw => aw.RequestedTime == appointment.RequestedTime)
                .ToList();

            //makes it so that only employees with empty time slots during requested time are left in list
            foreach(var emp in appointmentsWithOverlappingTimes)
            {
                listOfAllEmployees.Remove(emp.Employee.FullName);
            }    

            //raise error if doubleBookings found an entry
            if(doubleBookings != null) 
            {
                ModelState.AddModelError("RequestedTime", employee.FullName + " is booked during that time slot. Other employees available: " + listOfAllEmployees.Count + " | " + string.Join( ", ", listOfAllEmployees));
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
            var isDoubleBooked = _context.Appointments
                .Where(st => st.RequestedTime == appointment.RequestedTime)
                .Where(st=> st.EmployeeId == appointment.EmployeeId)
                .SingleOrDefault();

//             An unhandled exception occurred while processing the request.
//             InvalidOperationException: The instance of entity type 'Appointment' cannot be tracked because another instance with the same key value for {'Id'} is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the conflicting key values.
//             
//             var copyOfId = appointment.Id; //so doesn't throw an error
//             var entryBeforeEdit = _context.Appointments
//                 .Where(eb => eb.Id == appointment.Id)
//                 .SingleOrDefault();
//              if(isDoubleBooked != null && entryBeforeEdit == null ) //if records are found, then requested time would double book the employee - raise an error

            if(isDoubleBooked != null) //if records are found, then requested time would double book the employee - raise an error
            {
                ModelState.AddModelError("RequestedTime", "The requested appointment overlaps with another appointment for this employee");
            }


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

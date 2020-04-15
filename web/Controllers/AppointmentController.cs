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
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName");
            return View();
        }
        

        // POST: Appointment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,PhoneNumber,AppointmentNotes,EmployeeId,RequestedTime,Id")] Appointment appointment)
        {

            var employee = _context.Employees.Find(appointment.EmployeeId);
            var employeeStartTime = employee.StartTime.TimeOfDay;
            DateTime myTime = default(DateTime).Add(employeeStartTime);
            // var wholeDate = DateTime.Parse(employeeStartTime);
            // var time = wholeDate - wholeDate.Date;



           //Searches for other appointments with the same time and employee (ie.for double booking events)
            var isDoubleBooked = _context.Appointments
                .Where(st => st.RequestedTime == appointment.RequestedTime)
                .Where(st=> st.EmployeeId == appointment.EmployeeId)
                .SingleOrDefault();
            
            //if records are found indicating a double book event
            //Make suggestion for possible appointments with employees
            // string list_of= "";
            // if(isDoubleBooked != null) 
            // {
                
            //     var listOfEmployeesWithAvailableTime = _context.Appointments
            //         .Where(lo => lo.RequestedTime != appointment.RequestedTime)
            //         .Where(lo => lo.EmployeeId != appointment.EmployeeId)
            //         .ToList();
                
            //     list_of= "";
            //     foreach(var emp in listOfEmployeesWithAvailableTime)
            //     {
            //         list_of += emp?.Employee.FullName;

            //     }
            // }
            
            //makes a list of all available employees at the time someone is making an appointment
            var listOfAllEmployees = _context.Employees.Select(x=>x.FullName).ToList();

            var appointmentsWithOverlappingTimes = _context.Appointments
                .Where(aw => aw.RequestedTime == appointment.RequestedTime)
                .ToList();

            foreach(var emp in appointmentsWithOverlappingTimes)
            {
                listOfAllEmployees.Remove(emp.Employee.FullName);
            }    

            string availableEmployees = string.Join( ", ", listOfAllEmployees);

            if(isDoubleBooked != null) //if records are found, then requested time would double book the employee - raise an error
            {
                ModelState.AddModelError("RequestedTime", "This date and time would result in doublebooking. Choose another Date/time. Available employees at this time slot: " + availableEmployees);
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

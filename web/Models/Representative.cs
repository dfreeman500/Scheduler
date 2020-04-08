using System;
using System.Collections.Generic;
namespace web.Models
{
    public class Base
    {
        public Guid Id { get; set; } //GUID or UUID is an acronym for 'Globally Unique Identifier' or 'Universally Unique Identifier'. It is a 128-bit integer number used to identify resources. 
    }
    // A table of employees. 
    // Each employee will have multiple appointments
    public class Employee : Base // Base Generates Employee.Id Guid for identifing an Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName 
        {
            get
            {
                return FirstName + " " + LastName;
            }

        }
        public ICollection<Appointment> Appointments { get; set; } //a collection of a appointments
    }
    // A table of appointments
    public class Appointment : Base // Base Generates Appointment.Id Guid for identifing an Appointment
    {
        // Single use customer
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string AppointmentNotes { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime RequestedTime { get; set; }
    }
}
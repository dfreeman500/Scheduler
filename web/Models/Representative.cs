using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace web.Models
{
    public class Base
    {
        public Guid Id { get; set; } //GUID or UUID is an acronym for 'Globally Unique Identifier' or 'Universally Unique Identifier'. It is a 128-bit integer number used to identify resources. 
    }
    // A table of employees. 
    // Each employee will have multiple appointments
    public class Employee : Base 
    {
        [Display(Name = "First Name")] //Display attributes so it will show correctly in view/webpage
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }

        }
        public ICollection<Appointment> Appointments { get; set; } 



    }
    // A table of appointments
    public class Appointment : Base // Base Generates Appointment.Id Guid for identifing an Appointment
    {

        [Required]
        public string Name { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Appointment Notes")]
        public string AppointmentNotes { get; set; }

        [Display(Name = "Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Display(Name = "Requested Time")]

        public DateTime RequestedTime { get; set; }


    }




}
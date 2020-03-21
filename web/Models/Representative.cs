using System;
namespace web.Models
{
    /// <summary>
    ///One-to-Many
    ///We need to define the relationship as a collection on one side, and a complex object with an index on the other side.
    /// </summary>
    public class Base
    {
        public Guid Id { get; set; } //GUID or UUID is an acronym for 'Globally Unique Identifier' or 'Universally Unique Identifier'. It is a 128-bit integer number used to identify resources. 
    }
    public class Representative : Base // A table of representatives or employee. Each employee will have multipel appointments
    {
        public ICollection<Appointment> Appointments { get; set; } //a collection of a appointments
    }
    public class Appointment : Base //a table of appointments
    {
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public string Notes { get; set; } // Ex: put in needs or preferences for that specific appointment
        public DateTime RequestedTime{get; set;} 
        //I might use an int for this instead. I want to be able to do something like Client A wants an appointment time of 9 and determine who if anyone is available.
    }

    public class Client //A table of clients
    {
        public string FirstName { get; set; }
        public string FirstName { get; set; }
        public int PhoneNumber { get; set; } //Can format later from int data type if want to
    }
}
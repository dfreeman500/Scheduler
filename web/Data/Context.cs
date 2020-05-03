using Microsoft.EntityFrameworkCore;
using web.Models;

namespace web.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        
        //Register Employees table
        public DbSet<Employee> Employees { get; set; }
        
          //Register Appointments table
        public DbSet<Appointment> Appointments { get; set; }
     
    }
}
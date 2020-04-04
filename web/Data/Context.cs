using Microsoft.EntityFrameworkCore;
using web.Models;

namespace web.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        //Configure Technology and ExampleProject Foreign Keys for the ExampleProjectTechnology Table 
        // protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //     modelBuilder.Entity<ExampleProjectTechnology>().HasKey(t => new { t.TechnologyId, t.ExampleProjectId });
        // }
        
        //Register Employees table
        public DbSet<Employee> Employees { get; set; }
        
          //Register Appointments table
        public DbSet<Appointment> Appointments { get; set; }
     
    }
}
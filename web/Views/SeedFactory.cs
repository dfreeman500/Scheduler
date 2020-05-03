using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using web.Data;
using web.Models;

namespace web
{
    public class SeedFactory
    {
        public static void Initialize(Context context)
        {
            // This line ensures  database exists.
            context.Database.EnsureCreated();
            if (!context.Set<Employee>().Any())
            {

                var employees = new List<Employee>()
                {
                    new Employee
                    {
                        FirstName = "Dr.",
                        LastName = "Strange",
                        StartTime = new DateTime(2020, 5, 2, 09, 0, 0),
                        EndTime = new DateTime(2020, 5, 2, 17, 0, 0),
                    },
                    new Employee
                    {
                        FirstName = "Dr. ",
                        LastName = "Banner",
                        StartTime = new DateTime(2020, 5, 2, 08, 0, 0),
                        EndTime = new DateTime(2020, 5, 2, 16, 0, 0),
                    },
                    new Employee
                    {
                        FirstName = "Dr.",
                        LastName = "Manhattan",
                        StartTime = new DateTime(2020, 5, 2, 10, 0, 0),
                        EndTime = new DateTime(2020, 5, 2, 19, 0, 0),
                    },

                };

                context.AddRangeAsync(employees);
                context.SaveChangesAsync();
            }
        }
    }
}

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
                    },
                    new Employee
                    {
                        FirstName = "Dr. ",
                        LastName = "Banner",
                    },
                    new Employee
                    {
                        FirstName = "Dr.",
                        LastName = "Dre",
                    },

                };

                context.AddRangeAsync(employees);
                context.SaveChangesAsync();
            }
        }
    }
}

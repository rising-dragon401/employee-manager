using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Data.Entities;

namespace server.Data
{
    public class DataSeeder
    {
        private readonly EmployeeDbContext _dbContext;
        public DataSeeder(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public static void SeedData(EmployeeDbContext _dbContext)
        {   
            _dbContext.Database.EnsureCreated();

            if(!_dbContext.Employees.Any())
            {
                SeedEmployees(); 
            }

            _dbContext.SaveChanges();
        }

        private static void SeedEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee
                {
                   Id = Guid.NewGuid(),
                   Name = "Richard Hendricks",
                   Email = "contact@richardhendrinks.com",
                   Position = "Sales",
                   StartDate = new DateTime(2014, 04, 22)
                },
               new Employee
               {
                   Id = Guid.NewGuid(),
                   Name = "Bertram Gilfoye",
                   Email = "contact@bertramgilfoye.com",
                   Position = "HR Manager",
                   StartDate = new DateTime(2015, 06, 12)
               },
               new Employee
               {
                   Id = Guid.NewGuid(),
                   Name = "Denish Chugtai",
                   Email = "contact@denishchutai.com",
                   Position = "Data Analyst",
                   StartDate = new DateTime(2016, 06, 20)
               }
            };
        }
    }
}
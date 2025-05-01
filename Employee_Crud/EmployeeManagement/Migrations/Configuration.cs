namespace EmployeeManagement.Migrations
{
    using EmployeeManagement.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeManagement.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeManagement.Models.ApplicationDbContext context)
        {
            context.Employees.AddOrUpdate(
       
               new Employee
               {
                   Name = "Ajay Bhosle",
                   Email = "ajay@gmail.com",
                   Position = "Software Developer",
                   DateOfJoining = new DateTime(2025, 05, 04)
               },
               new Employee
               {
                   Name = "Vijay Lonkar",
                   Email = "Vijay@gmail.com",
                   Position = "HR Manager",
                   DateOfJoining = new DateTime(2025, 06, 08)
               }
           );
        }
    }
}

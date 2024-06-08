using System;
using System.Collections.Generic;
using System.Linq;
using WebApiProject.Models;

namespace WebApiProject.Data
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext _dbContext;

        public DataSeeder(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void Seed()
        {
            var employees = new List<Customer>();

            if (!_dbContext.Customers.Any())
            {
                employees.Add(new Customer()
                {
                    Name = "Hafi Junaid",
                    FatherName = "Ahmed",
                    Age = 31,
                    DateOfBirth = new DateTime(1994, 3, 21),
                    Gender = "Male",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                employees.Add(new Customer()
                {
                    Name = "Zahid",
                    FatherName = "Khan ",
                    Age = 30,
                    DateOfBirth = new DateTime(1996, 6, 15),
                    Gender = "Male",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                employees.Add(new Customer()
                {
                    Name = "Abdul Basit",
                    FatherName = "Shafique Ahmed",
                    Age = 25,
                    DateOfBirth = new DateTime(1997, 5, 19),
                    Gender = "Male",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });
                employees.Add(new Customer()
                {
                    Name = "Shan",
                    FatherName = "Ahmed",
                    Age = 25,
                    DateOfBirth = new DateTime(1998, 8, 20),
                    Gender = "Male",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });
                employees.Add(new Customer()
                {
                    Name = "Mushtaq",
                    FatherName = "Ali",
                    Age = 32,
                    DateOfBirth = new DateTime(1993, 7, 22),
                    Gender = "Male",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                // Add the employees to the database
                _dbContext.Customers.AddRange(employees);
                _dbContext.SaveChanges();
            }
        }
    }
}

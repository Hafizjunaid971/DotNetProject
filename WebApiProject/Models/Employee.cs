using System;

namespace WebApiProject.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}

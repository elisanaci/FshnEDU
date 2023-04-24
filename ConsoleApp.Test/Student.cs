using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public class Student
    {
        //Identifier
        public int Id { get; set; }
        //public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        
        public Student()
        {
        }

        public Student(string firstName)
        {
            FirstName = firstName;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            var age = DateTime.Now.Year - DateOfBirth.Year;
            return age;
        }


    }
}

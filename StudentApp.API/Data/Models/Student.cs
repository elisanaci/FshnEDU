using StudentApp.API.Data.Base;

namespace StudentApp.API.Data.Models
{
    public class Student:BaseClass
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public double GPA { get; set; }
    }
}

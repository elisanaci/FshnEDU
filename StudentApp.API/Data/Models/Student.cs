namespace StudentApp.API.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public double GPA { get; set; }

        public DateTime DateCreated { get; set; }


    }
}

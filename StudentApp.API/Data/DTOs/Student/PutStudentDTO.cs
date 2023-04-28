namespace StudentApp.API.Data.DTOs.Student
{
    public class PutStudentDTO
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public double GPA { get; set; }

        //Add a reference to Subject table
        public int SubjectId { get; set; }
    }
}

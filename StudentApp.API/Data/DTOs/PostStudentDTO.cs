namespace StudentApp.API.Data.DTOs
{
    public class PostStudentDTO
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public double GPA { get; set; }
    }
}

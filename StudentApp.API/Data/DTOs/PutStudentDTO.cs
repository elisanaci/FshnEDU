﻿namespace StudentApp.API.Data.DTOs
{
    public class PutStudentDTO
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public double GPA { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc;
using StudentApp.API.Data;
using StudentApp.API.Data.DTOs.Student;
using StudentApp.API.Data.Models;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private AppDbContext _appDbContext;
        public StudentsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            var allStudents = _appDbContext.Students.ToList();
            return Ok(allStudents);
        }

        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _appDbContext.Students.FirstOrDefault(x => x.Id == id);
            return Ok($"Studenti me id = {id} u kthye me sukses!");
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] PostStudentDTO payload)
        {
            //1. Krijo nje objekt Student me te dhenat e marra nga payload
            Student newStudent = new Student()
            {
                StudentNumber = payload.StudentNumber,
                FirstName = payload.FirstName,
                LastName = payload.LastName,
                DOB = DateTime.UtcNow.AddYears(-20),
                GPA = payload.GPA,
                DateCreated = DateTime.UtcNow
            };

            _appDbContext.Students.Add(newStudent);
            _appDbContext.SaveChanges();

            return Ok("Studenti u krijua me sukses!");
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody]PutStudentDTO payload, int id)
        {
            //1. Duke perdour ID marrim te dhenat nga databaza
            var student = _appDbContext.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
                return NotFound();

            //2. Perditesojme Studentin e DB me te dhenat e payload-it
            student.StudentNumber = payload.StudentNumber;
            student.FirstName = payload.FirstName;
            student.LastName = payload.LastName;
            student.DOB = DateTime.UtcNow.AddYears(-20);
            student.GPA = payload.GPA;

            //3. Ruhen te dhenat ne database
            _appDbContext.Students.Update(student);
            _appDbContext.SaveChanges();

            return Ok("Studenti u modifikua me sukses!");
        }

        [HttpDelete("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            //1. Duke perdour ID marrim te dhenat nga databaza
            var student = _appDbContext.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
                return NotFound();

            //2. Fshijme studentin nga DB
            _appDbContext.Students.Remove(student);
            _appDbContext.SaveChanges();

            return Ok($"Studenti me id = {id} u fshi me sukses!");
        }
    }
}

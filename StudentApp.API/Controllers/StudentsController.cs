using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.API.Data.DTOs;
using StudentApp.API.Data.Models;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            //Marrim te gjithe studentet nga databasa

            //return NotFound();
            //return BadRequest();

            return Ok();
        }

        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            return Ok($"Studenti me id = {id} u kthye me sukses!");
        }

        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetStudentById/RequestUrl")]
        public IActionResult GetStudentByIdRequestUrl(int id, string firstName, string lastName)
        {
            return Ok($"Studenti me id = {id} u kthye me sukses!");
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] PostStudentDTO payload)
        {

            return Ok("Studenti u krijua me sukses!");
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent()
        {

            return Ok("Studenti u modifikua me sukses!");
        }

        [HttpDelete("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {

            return Ok($"Studenti me id = {id} u fshi me sukses!");
        }



    }
}

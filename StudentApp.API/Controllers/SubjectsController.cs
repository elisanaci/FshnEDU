using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.API.Data.DTOs.Subject;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetAllSubjects")]
        public IActionResult GetAllSubjects()
        {
            //Marrim te gjithe lendet/subjects nga databasa

            //return NotFound();
            //return BadRequest();

            return Ok();
        }

        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetSubjectById/{id}")]
        public IActionResult GetSubjectById(int id)
        {
            return Ok($"Subjecti me id = {id} u kthye me sukses!");
        }
        
        [HttpPost("AddSubject")]
        public IActionResult AddSubject([FromBody] PostSubjectDTO payload)
        {

            return Ok("Subjecti u krijua me sukses!");
        }

        [HttpPut("UpdateSubject")]
        public IActionResult UpdateSubject([FromBody]PutSubjectDTO payload, int id)
        {
            //1. Duke perdour ID marrim te dhenat nga databaza

            //2. Perditesojme Subjectin e DB me te dhenat e payload-it

            //3. Ruhen te dhenat ne database

            return Ok("Subjecti u modifikua me sukses!");
        }

        [HttpDelete("DeleteSubject/{id}")]
        public IActionResult DeleteSubject(int id)
        {

            return Ok($"Subjecti me id = {id} u fshi me sukses!");
        }
    }
}

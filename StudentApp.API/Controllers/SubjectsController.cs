using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.API.Data;
using StudentApp.API.Data.DTOs.Subject;
using StudentApp.API.Data.Models;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private AppDbContext _appDbContext;
        public SubjectsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetAllSubjects")]
        public IActionResult GetAllSubjects()
        {
            var allSubjects = _appDbContext.Subjects.ToList();

            return Ok(allSubjects);
        }

        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetSubjectById/{id}")]
        public IActionResult GetSubjectById(int id)
        {
            var subject = _appDbContext.Subjects.FirstOrDefault(x => x.Id == id);
            
            if(subject == null)
            {
                return NotFound();
            }

            return Ok(subject);
        }
        
        [HttpPost("AddSubject")]
        public IActionResult AddSubject([FromBody] PostSubjectDTO payload)
        {
            Subject newSubject = new Subject()
            {
                Name = payload.Name,
                Code = payload.Code,
                DateCreated = DateTime.UtcNow
            };

            _appDbContext.Subjects.Add(newSubject);
            _appDbContext.SaveChanges();
            
            return Ok("Subjecti u krijua me sukses!");
        }

        [HttpPut("UpdateSubject")]
        public IActionResult UpdateSubject([FromBody]PutSubjectDTO payload, int id)
        {
            //1. Duke perdour ID marrim te dhenat nga databaza
            var subject = _appDbContext.Subjects.FirstOrDefault(x => x.Id == id);

            //2. Perditesojme Subjectin e DB me te dhenat e payload-it
            if (subject == null)
                return NotFound();

            subject.Name = payload.Name;
            subject.Code = payload.Code;

            //3. Ruhen te dhenat ne database
            _appDbContext.Subjects.Update(subject);
            _appDbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete("DeleteSubject/{id}")]
        public IActionResult DeleteSubject(int id)
        {
            var subject = _appDbContext.Subjects.FirstOrDefault(x => x.Id == id);

            if (subject == null)
                return NotFound();

            _appDbContext.Subjects.Remove(subject);
            _appDbContext.SaveChanges();

            return Ok($"Subjecti me id = {id} u fshi me sukses!");
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using StudentApp.API.Data.DTOs.Student;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //Koment

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

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] PostStudentDTO payload)
        {

            return Ok("Studenti u krijua me sukses!");
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody]PutStudentDTO payload, int id)
        {
            //1. Duke perdour ID marrim te dhenat nga databaza

            //2. Perditesojme Studentin e DB me te dhenat e payload-it

            //3. Ruhen te dhenat ne database

            return Ok("Studenti u modifikua me sukses!");
        }

        [HttpDelete("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {

            return Ok($"Studenti me id = {id} u fshi me sukses!");
        }
    }
}

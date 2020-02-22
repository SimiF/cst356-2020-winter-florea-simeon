using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Instructor>> Get()
        {
            return Ok(getStudents());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Instructor instructor)
        {
            instructor.Id = getNextId();

            InMemory.Instructors.Add(instructor);

            return CreatedAtAction(nameof(GetById), new { id = instructor.Id }, instructor);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            
            var instructor = InMemory.Instructors.FirstOrDefault(i => i.Id == id);

            if (instructor == null)
            {
                return NotFound();
            }

            return Ok(instructor);
        }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }

        private List<Instructor> getStudents()
        {
            return InMemory.Instructors;
        }  

        private int getNextId()
        {
            return InMemory.Instructors.Max(p => p.Id) + 1;
        }
    }
}
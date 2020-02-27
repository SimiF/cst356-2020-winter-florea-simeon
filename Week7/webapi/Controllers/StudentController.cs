using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            var result = _dbContext.Student.ToList();
            return Ok(result);
        }

        [HttpGet("{student_id}")]
        public ActionResult<Student> GetStudent(int studentId)
        {
            var student = _dbContext.Student
                .SingleOrDefault(s => s.StudentId == studentId);

            if (student != null) {
                return student;
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Student> AddProduct(Student student)
        {
            _dbContext.Student.Add(student);
            _dbContext.SaveChanges();

            // return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{student_id}")]
        public ActionResult DeleteProduct(int studentId)
        {
            var student = new Student { StudentId = studentId };

            _dbContext.Student.Attach(student);
            _dbContext.Student.Remove(student);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{student_id}")]
        public ActionResult UpdateProduct(int studentId, Student studentUpdate)
        {
            var student = _dbContext.Student
                .SingleOrDefault(s => s.StudentId == studentId);

            if (student != null)
            {
                student.StudentId = studentUpdate.StudentId;
                student.EmailAddress = studentUpdate.EmailAddress;                               

                _dbContext.Update(student);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
    }
}
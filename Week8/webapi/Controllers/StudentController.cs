using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger _logger;

        public StudentController(IStudentService studentService, ILoggerFactory loggerFactory)
        {
            _studentService = studentService;
            _logger = loggerFactory.CreateLogger("Controllers.StudentController");
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            _logger.LogDebug("Getting all students");            

            return Ok(_studentService.GetAllStudents());
        }       
    }
}
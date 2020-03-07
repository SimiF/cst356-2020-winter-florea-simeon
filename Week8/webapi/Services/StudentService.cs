using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace studentService {
    public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    private readonly ILogger _logger;

    public StudentService(IStudentRepository studentRepository, ILoggerFactory loggerFactory)
    {
        _studentRepository = studentRepository;
        _logger = loggerFactory.CreateLogger("Controllers.StudnetService");
    }

    public List<StudentViewModel> GetAllStudents()
    {
        var studentViewModels = new List<StudentViewModel>();

        foreach(var student in _studentRepository.GetAllStudents())
        {
            studentViewModels.Add(new StudentViewModel {
                StudentId = student.StudentId,
                EmailAddress = student.EmailAddress,
                Special = BusinessRules.isSpecial(student)
            });
            if (BusinessRules.hasValidEmailAddress(student))
            {
                _logger.LogInformation("Student does not have valid email address: " + student.StudentId);
            }
            if (BusinessRules.hasValidStudentId(student))
            {
                _logger.LogInformation("Student does not have valid student id: " + student.EmailAddress);
            }
            
        }

        return studentViewModels;
    }
}
}
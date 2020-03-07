using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using studentService;

public class StudentServiceTests 
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock    

    [SetUp]
    public void Setup()
    {
        var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();
        _studentService = new StudentService(_studentRepository, loggerFactory);        
    }

    [Test]
    public void ShouldReturnOneSpecialStudent()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 10,
                    EmailAddress = "simeon.florea@oit.edu"
                },
                new Student {
                    StudentId = 15,
                    EmailAddress = "robert.florea@oit.edu"
                }
            }
        );        

        // Assert (NUnit Assertions) (Then)
        Assert.That(_studentService.GetAllStudents().Any(student => student.Special), Is.EqualTo(true));

        // Assert (FluentAssertions) (Then)
        _studentService.GetAllStudents().Any(student => student.Special).Should().BeTrue();
    }    

    [Test]
    public void ShouldReturnNoSpecialStudents()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 10,
                    EmailAddress = "simeon.florea@oit.edu"
                },
                new Student {
                    StudentId = 20,
                    EmailAddress = "robert.florea@oit.edu"
                }
            }
        );        

        // Assert (NUnit Assertions) (Then)
        Assert.That(_studentService.GetAllStudents().Any(student => student.Special), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        _studentService.GetAllStudents().Any(student => student.Special).Should().BeFalse();
    }    
}
using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "2221243",
                EmailAddress = "b.morphew@lab,edu"
            },
            new Student {
                Id = 2,
                StudentId = "2229612",
                EmailAddress = "d.shockley@lab.edu"
            },
            new Student {
                Id = 3,
                StudentId = "2229183",
                EmailAddress = "c.hoch@lab.edu"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                Id = 1,
                FirstName = "Marcos",
                MiddleInitial = "D",
                LastName = "Monroig"
            },
            new Instructor {
                Id = 2,
                FirstName = "Myrta",
                MiddleInitial = "S",
                LastName = "Merten"
            },
            new Instructor {
                Id = 3,
                FirstName = "Marco",
                MiddleInitial = "I",
                LastName = "Lovell"
            }               
        };
    }
}
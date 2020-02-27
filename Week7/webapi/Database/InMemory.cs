using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {    
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
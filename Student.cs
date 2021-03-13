using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-05-jeong98-dykstra1] - This is really just creating the data model the basket if I can say
    public class Student
    {
        public int ID { get; set; }
        public string FirstMidName { get; set; }
        public String LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

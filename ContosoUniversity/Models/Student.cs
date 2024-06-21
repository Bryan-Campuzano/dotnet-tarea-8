using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public required string LastName { get; set; }
        public required string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public required ICollection<Enrollment> Enrollments { get; set; }
    }
}
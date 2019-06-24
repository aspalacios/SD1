using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class ResultViewModel
    {
        public Student _studentDetail { get; set; }

        public List <Enrollment> _enrollmentDetails { get; set; }

        public List <Course> _courseDetails { get; set; }
    }
}
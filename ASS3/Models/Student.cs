using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<CourseStudent> courses { get; set; }
    }
}

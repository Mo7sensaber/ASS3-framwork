using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3.Models
{
    public class CourseStudent
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public virtual Student student {  get; set; }
        public virtual Course course { get; set; }
        public double grade { get; set; }
    }
}

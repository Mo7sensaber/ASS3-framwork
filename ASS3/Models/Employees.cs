using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Address {  get; set; }
        public int deptID { get; set; }
        public virtual Department WorkFor {  get; set; }
    }
}

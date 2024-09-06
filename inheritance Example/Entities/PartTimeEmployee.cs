using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Example.Entities
{
    internal class PartTimeEmployee:Employee
    {
        public int NumberOfHour { get; set; }
        public double HourRate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Employees> Employees { get; set; }  
    }
}

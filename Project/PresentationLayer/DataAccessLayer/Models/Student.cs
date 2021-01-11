﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IndexNumber { get; set; }
        public int Colloquium { get; set; }
        public int SeminaryWork { get; set; }
        public int Homework { get; set; }
        public int Activity { get; set; }
    }
}

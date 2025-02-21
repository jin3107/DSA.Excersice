using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        public int Id { get; set; }
        public double M1 { get; set; }
        public double M2 { get; set; }
        public double M3 { get; set; }
        public double Average => (M1 + M2 + M3) / 3.0;
    }
}

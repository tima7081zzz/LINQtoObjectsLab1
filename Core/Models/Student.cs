using Core.Infrastructure.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Infrastructure.Interfaces;

namespace Core.Models
{
    public class Student
    { 
        public string FullName { get; set; }
        public Group Group { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AvgMark { get; set; }
        public Work Work { get; set; }
        public Professor Professor { get; set; }
    }
}

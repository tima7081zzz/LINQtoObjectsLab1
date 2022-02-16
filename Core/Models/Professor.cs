using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Infrastructure.Interfaces.Enums;

namespace Core.Models
{
    class Professor
    {
        public string FullName { get; set; }
        public Position Position { get; set; }
        public IEnumerable<Student> Students{ get; set; }
    }
}

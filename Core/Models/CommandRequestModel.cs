using System.Collections.Generic;
using Core.Models;

namespace Core.Infrastructure
{
    public class CommandRequestModel
    {
        public ICollection<Student> Students { get; set; }
        public ICollection<Professor> Professors { get; set; }
        public ICollection<Work> Works{ get; set; }
    }
}
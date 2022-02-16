using System.Collections.Generic;
using Core.Models;

namespace Core.Infrastructure
{
    public class CommandModelWrapper
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Professor> Professors { get; set; }
        public IEnumerable<Work> Work{ get; set; }
    }
}
using System.Collections.Generic;

namespace Core.Models
{
    public class CommandRequestModel
    {
        public ICollection<Student> Students { get; set; }
        public ICollection<Professor> Professors { get; set; }
        public ICollection<Work> Works{ get; set; }
    }
}
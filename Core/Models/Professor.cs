using System.Collections.Generic;
using Core.Infrastructure.Interfaces.Enums;

namespace Core.Models
{
    public class Professor
    {
        public string FullName { get; set; }
        public Position Position { get; set; }
        public ICollection<Student> Students{ get; set; }
    }
}

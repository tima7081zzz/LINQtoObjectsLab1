using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Infrastructure.Interfaces;

namespace Core.Models
{
    public class Work
    {
        public string Item { get; set; }
        public int Mark { get; set; }
        public Student Student { get; set; }
    }
}

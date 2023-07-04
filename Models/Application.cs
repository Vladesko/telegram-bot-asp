using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string NumberPhone { get; set; }
        public DateTime Time { get; set; }
    }
}

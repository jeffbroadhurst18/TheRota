using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRota.Models
{
    public class Rota
    {
        public int Id { get; set; }
        public Fixture Fixture { get; set; }
        public Role Role { get; set; }
        public Person Person { get; set; }
    }
}

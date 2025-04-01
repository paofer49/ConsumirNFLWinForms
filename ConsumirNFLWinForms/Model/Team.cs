using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirNFLWinForms.Model
{
    class Team
    {
        public int TeamID { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Stadium { get; set; }
        public int FoundationYear { get; set; }
        public string? Conference { get; set; }
    }
}

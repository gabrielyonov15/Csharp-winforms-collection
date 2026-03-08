using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamOrderingSystem
{
    public class IceCreamControl
    {
        public string Name { get; set; }
        public string Flavor { get; set; } 
        public string Size { get; set; }  

        public bool Vanilla { get; set; }
        public bool Cookies { get; set; }
        public bool WaferSticks { get; set; }
        public bool Sprinkles { get; set; }
        public bool Caramel { get; set; }
    }
}
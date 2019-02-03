using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_WladimirCanar
{
    public class Desk
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public AddQuote.Materials DesktopMaterial { get; set; }
        public AddQuote.rush Rush { get; set;}
    }
}

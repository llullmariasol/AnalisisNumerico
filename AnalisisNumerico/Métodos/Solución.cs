using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class Solución
    {
        public int iteru { get; set; }
        public double erel { get; set; }
        public double sol { get; set; }
        public string Error { get; set; }

        public Solución()
        {
            iteru = 0;
            erel = 0;
            sol = 0;
            Error = null;
        }
    }
}

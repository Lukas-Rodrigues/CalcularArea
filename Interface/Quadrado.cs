using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Quadrado: AreaCalculavel
    {
        public double Lado { get; set; }

        public double calculaArea()
        {
            return Lado * Lado;
        }
    }
}

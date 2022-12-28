using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Circulo:AreaCalculavel
    {
        public double Raio { get; set; }

        public double calculaArea()
        {
            return Math.PI * Raio;
        }
    }
}

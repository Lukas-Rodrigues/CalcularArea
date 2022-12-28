using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Retangulo:AreaCalculavel
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double calculaArea()
        {
            return Base * Altura;
        }
    }
}

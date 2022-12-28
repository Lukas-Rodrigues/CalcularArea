using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.Altura = 15;
            retangulo.Base = 23;
            Console.WriteLine("A area do retangulo é: " + retangulo.calculaArea() + "cm²");

            Quadrado quadrado= new Quadrado();
            quadrado.Lado = 14;
            Console.WriteLine("A area do quadrado é: " + quadrado.calculaArea() + "cm²");
            
            Circulo circulo  =new Circulo(); 
            circulo.Raio = 15;
            Console.WriteLine("A area do quadrado é: " + circulo.calculaArea() + "cm²");

            Console.ReadKey();
        }
    }
}

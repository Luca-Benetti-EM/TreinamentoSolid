using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(10, 10);

            Quadrado quadrado = new Quadrado(10);

            Console.WriteLine(retangulo.getArea());
            Console.WriteLine(quadrado.getArea());
            Console.ReadKey();
        }
    }
}

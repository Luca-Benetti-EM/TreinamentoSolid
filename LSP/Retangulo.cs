using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Retangulo
    {
        public int Largura { get; }

        public int Altura { get; }

        public int getArea()
        {
            return Altura*Largura;
        }

        public Retangulo(int altura, int largura)
        {
            Largura = largura;
            Altura = altura;
        }

    }
}

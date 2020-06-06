using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOCP
{
    public class ArquivoWord : IArquivo
    {
        public void GereArquivo()
        {
            Console.WriteLine("Arquivo Word gerado com sucesso.");
        }
    }
}

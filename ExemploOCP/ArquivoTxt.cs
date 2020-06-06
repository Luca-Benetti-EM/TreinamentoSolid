using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOCP
{
    public class ArquivoTxt : IArquivo
    {
        public void GereArquivo()
        {
            Console.WriteLine("Arquivo TXT gerado com sucesso.");
        }
    }
}

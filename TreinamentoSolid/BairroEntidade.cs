using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoSolid
{
    public class BairroEntidade
    {
        public int Identifcador { get; set; }
        public string Descricao { get; set; }
        public CidadeEntidade Cidade { get; set; }
    }
}

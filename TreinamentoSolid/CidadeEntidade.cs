using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoSolid
{
    public class CidadeEntidade
    {
        public int Identificador { get; set; }

        public int CodigoIBGE { get; set; }

        public string Descricao { get; set; }

        public EstadoEntidade Estado { get; set; }
    }
}

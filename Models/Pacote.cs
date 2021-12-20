using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agencia1.Models
{
    public class Pacote

    {
        public int PacoteId { get; set; }

        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Data { get; set; }
        public string Retorno { get; set; }

        }
}

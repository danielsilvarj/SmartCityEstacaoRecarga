using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Dominio.Entidades
{
    public class EstacaoRecarga : EntidadeBase
    {
        public string Nome { get; set; }
        public int TipoEstacao { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

    }
}

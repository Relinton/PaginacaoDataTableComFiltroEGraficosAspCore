using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppGraficosHighcharts.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int Pessimo { get; set; }
        public int Ruim { get; set; }
        public int Indiferente { get; set; }
        public int Bom { get; set; }
        public int Otimo { get; set; }
    }
}

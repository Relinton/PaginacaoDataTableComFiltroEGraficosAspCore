using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppGraficosHighcharts.Models;

namespace WebAppGraficosHighcharts.Services
{
    public class AvaliacaoService
    {
        public static List<Avaliacao> BuscarAvaliacoes()
        {
            var lista = new List<Avaliacao>();
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 1, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 0 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 1, Indiferente = 0, Bom = 0, Otimo = 0 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 1, Indiferente = 0, Bom = 0, Otimo = 0 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 1, Indiferente = 0, Bom = 0, Otimo = 0 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            lista.Add(new Avaliacao { Id = 123123, Ruim = 0, Pessimo = 0, Indiferente = 0, Bom = 0, Otimo = 1 });
            return lista;
        }
    }
}

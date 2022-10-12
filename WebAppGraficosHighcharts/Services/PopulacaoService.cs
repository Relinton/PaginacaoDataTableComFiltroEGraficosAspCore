using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppGraficosHighcharts.Models;

namespace WebAppGraficosHighcharts.Services
{
    public class PopulacaoService
    {
        public static List<Populacao> GetPopulacaoPorEstado()
        {
            var lista = new List<Populacao>();
            lista.Add(new Populacao { Cidade = "São Paulo", Populacao2017 = 45094, Populacao2010 = 39585 });
            lista.Add(new Populacao { Cidade = "Minas Gerais", Populacao2017 = 21119, Populacao2010 = 16715 });
            lista.Add(new Populacao { Cidade = "Rio de Janeiro", Populacao2017 = 16718, Populacao2010 = 15464 });
            lista.Add(new Populacao { Cidade = "Bahia", Populacao2017 = 15344, Populacao2010 = 10120 });
            lista.Add(new Populacao { Cidade = "Parana", Populacao2017 = 11320, Populacao2010 = 8912 });
            return lista;
        }
    }
}

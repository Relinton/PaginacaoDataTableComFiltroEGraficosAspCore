
using System.Collections.Generic;

namespace WebAppGraficosHighcharts.Services
{
    public class FuncionarioCargoService
    {
        public static Dictionary<string, int> BuscarCargos()
        {
            var lista = new Dictionary<string, int>();
            lista.Add("Programador Web", 500);
            lista.Add("Programador Mobile", 200);
            lista.Add("Cientista de Dados", 100);
            lista.Add("Analista de Infraestrutura", 100);
            return lista;
        }
    }
}






























//public static List<FuncionarioCargoViewModel> BuscarCargos()
//{
//    var lista = new List<FuncionarioCargoViewModel>
//            {
//                new FuncionarioCargoViewModel { Cargo = "Programador Web", QtdFuncionarios = 500 },
//                new FuncionarioCargoViewModel { Cargo = "Programador Mobile", QtdFuncionarios = 200 },
//                new FuncionarioCargoViewModel { Cargo = "Cientista de Dados", QtdFuncionarios = 100 },
//                new FuncionarioCargoViewModel { Cargo = "Analista de Infraestrutura", QtdFuncionarios = 100 },
//            };
//    return lista;
//}
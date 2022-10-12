
using System.Collections.Generic;

namespace WebAppGraficosHighcharts.Services
{
    public class FuncionarioContratoService
    {
        public static Dictionary<string, int> BuscarContratos()
        {
            var lista = new Dictionary<string, int>();
            lista.Add("CLT", 500);
            lista.Add("PJ", 400);
            lista.Add("Contrato Temporário", 100);
            lista.Add("Estágio", 100);
            return lista;
        }
    }
}






















//public static List<FuncionarioContratoViewModel> BuscarContratos()
//{
//    var lista = new List<FuncionarioContratoViewModel>
//            {
//                new FuncionarioContratoViewModel { Contrato = "CLT", QtdFuncionarios = 500 },
//                new FuncionarioContratoViewModel { Contrato = "PJ", QtdFuncionarios = 400 },
//                new FuncionarioContratoViewModel { Contrato = "Contrato Temporário", QtdFuncionarios = 100 },
//                new FuncionarioContratoViewModel { Contrato = "Estagiário", QtdFuncionarios = 100 },
//            };
//    return lista;
//}
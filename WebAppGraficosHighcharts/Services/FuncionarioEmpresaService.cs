
using System.Collections.Generic;

namespace WebAppGraficosHighcharts.Services
{
    public class FuncionarioEmpresaService
    {
        public static Dictionary<string, int> BuscarEmpresas()
        {
            var lista = new Dictionary<string, int>();
            lista.Add("Pinheiros Development", 10000);
            lista.Add("Pinheiros Dev", 500);
            lista.Add("Brasão Tecnologia", 200);
            lista.Add("Soft Plus Dev", 1500);
            lista.Add("Start Click", 500);
            lista.Add("Browser Consultoria e Informática", 1200);
            return lista;
        }
    }
}




















//public static List<FuncionarioEmpresaViewModel> BuscarEmpresas()
//{
//    var lista = new List<FuncionarioEmpresaViewModel>
//    {
//        new FuncionarioEmpresaViewModel { Empresa = "Pinheiros Development", QtdFuncionarios = 10000 },
//        new FuncionarioEmpresaViewModel { Empresa = "Pinheiros Dev", QtdFuncionarios = 500 },
//        new FuncionarioEmpresaViewModel { Empresa = "Brasão Tecnologia", QtdFuncionarios = 200 },
//        new FuncionarioEmpresaViewModel { Empresa = "Soft Plus Dev", QtdFuncionarios = 1500 },
//        new FuncionarioEmpresaViewModel { Empresa = "Start Click", QtdFuncionarios = 500 },
//        new FuncionarioEmpresaViewModel { Empresa = "Browser Consultoria e Informática", QtdFuncionarios = 1200 }
//    };
//    return lista;
//}

















//public JsonResult BuscarFuncionarios()
//{
//    List<FuncionarioEmpresaViewModel> empresaVM = new List<FuncionarioEmpresaViewModel>();


//    Dictionary<string, int> funcionarios = new Dictionary<string, int>();
//    funcionarios.Add("Pinheiros Development", 10000);
//    funcionarios.Add("Pinheiros Dev", 500);
//    funcionarios.Add("Brasão Tecnologia", 200);
//    funcionarios.Add("Soft Plus Dev", 1500);
//    funcionarios.Add("Start Click", 500);
//    funcionarios.Add("Browser Consultoria e Informática", 1200);
//    return Json(funcionarios);
//}

//public JsonResult BuscarCargos()
//{
//    Dictionary<string, int> cargos = new Dictionary<string, int>();
//    cargos.Add("Programador Web", 500);
//    cargos.Add("Programador Mobile", 200);
//    cargos.Add("Cientista de Dados", 100);
//    cargos.Add("Analista de Infraestrutura", 100);
//    return Json(cargos);
//}

//public JsonResult BuscarContratos()
//{
//    Dictionary<string, int> contratos = new Dictionary<string, int>();
//    contratos.Add("CLT", 500);
//    contratos.Add("PJ", 400);
//    contratos.Add("Contrato Temporário", 100);
//    contratos.Add("Estagiário", 100);
//    return Json(contratos);
//}
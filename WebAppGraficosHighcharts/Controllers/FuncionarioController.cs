using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppGraficosHighcharts.Factory;
using WebAppGraficosHighcharts.Models.Enum;
using WebAppGraficosHighcharts.Services;
using WebAppGraficosHighcharts.ViewModel;

namespace WebAppGraficosHighcharts.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Filtrar(FiltroFuncionarioViewModel filtroVM)
        {
            var tabela = new TabelaFuncionarioViewModel();
            if (filtroVM.TipoDeConsulta == ETipoConsulta.Empresa)
            {
                var lista = FuncionarioEmpresaService.BuscarEmpresas();
                tabela.FuncionariosEmpresa = FuncionarioFactory.ListaFuncionariosPorEmpresa(lista);
            }
            else if (filtroVM.TipoDeConsulta == ETipoConsulta.Cargo)
            {
                var lista = FuncionarioCargoService.BuscarCargos();
                tabela.FuncionariosCargo = FuncionarioFactory.ListaFuncionariosPorCargo(lista);
            }
            else
            {
                var lista = FuncionarioContratoService.BuscarContratos();
                tabela.FuncionariosContrato = FuncionarioFactory.ListaFuncionariosPorContrato(lista);
            }
            return PartialView("Partials/_TabelaFuncionarios", tabela);
        }
    }
}

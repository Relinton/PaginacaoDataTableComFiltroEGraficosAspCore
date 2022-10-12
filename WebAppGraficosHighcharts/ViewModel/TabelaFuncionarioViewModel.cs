using System.Collections.Generic;

namespace WebAppGraficosHighcharts.ViewModel
{
    public class TabelaFuncionarioViewModel
    {
        public TabelaFuncionarioViewModel()
        {
            FuncionariosEmpresa = new List<FuncionarioEmpresaViewModel>();
            FuncionariosCargo = new List<FuncionarioCargoViewModel>();
            FuncionariosContrato = new List<FuncionarioContratoViewModel>();
        }
        public IList<FuncionarioEmpresaViewModel> FuncionariosEmpresa { get; set; }
        public IList<FuncionarioCargoViewModel> FuncionariosCargo { get; set; }
        public IList<FuncionarioContratoViewModel> FuncionariosContrato { get; set; }
    }
}

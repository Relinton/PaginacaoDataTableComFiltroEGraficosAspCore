using System.Collections.Generic;

namespace WebAppGraficosHighcharts.ViewModel
{
    public class IndexFuncionarioViewModel
    {
        public IndexFuncionarioViewModel()
        {

        }

        public IndexFuncionarioViewModel(FiltroFuncionarioViewModel filtro, List<TabelaFuncionarioViewModel> funcionarios)
        {
            Filtro = filtro;
            Funcionarios = funcionarios;
        }

        public FiltroFuncionarioViewModel Filtro { get; set; }
        public ICollection<TabelaFuncionarioViewModel> Funcionarios { get; set; }
    }
}

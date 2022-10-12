
using System.ComponentModel.DataAnnotations;

namespace WebAppGraficosHighcharts.Models.Enum
{
    public enum ETipoConsulta
    {
        [Display(Name = "Relação por Empresa")]
        Empresa = 1,

        [Display(Name = "Relação por Cargo")]
        Cargo = 2,

        [Display(Name = "Relação por Contrato")]
        Contrato = 3
    }
}

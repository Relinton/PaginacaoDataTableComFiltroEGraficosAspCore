
using System;
using System.Collections.Generic;
using System.Linq;
using WebAppGraficosHighcharts.ViewModel;

namespace WebAppGraficosHighcharts.Factory
{
    public class FuncionarioFactory
    {
        public static List<FuncionarioEmpresaViewModel> ListaFuncionariosPorEmpresa(Dictionary<string, int> lista)
        {
            var listaVMFuncionarios = new List<FuncionarioEmpresaViewModel>();
            foreach (var item in lista)
            {
                listaVMFuncionarios.Add(FuncionarioPorEmpresa(item));
            }
            return listaVMFuncionarios.OrderByDescending(l => l.QtdFuncionarios).ToList();
        }

        public static FuncionarioEmpresaViewModel FuncionarioPorEmpresa(KeyValuePair<string, int> item)
        {
            return new FuncionarioEmpresaViewModel
            {
                Empresa = item.Key.Trim(),
                QtdFuncionarios = item.Value
            };
        }

        public static List<FuncionarioCargoViewModel> ListaFuncionariosPorCargo(Dictionary<string, int> lista)
        {
            var listaVMFuncionarios = new List<FuncionarioCargoViewModel>();
            foreach (var item in lista)
            {
                listaVMFuncionarios.Add(FuncionarioPorCargo(item));
            }
            return listaVMFuncionarios.OrderByDescending(l => l.QtdFuncionarios).ToList();
        }

        public static FuncionarioCargoViewModel FuncionarioPorCargo(KeyValuePair<string, int> item)
        {
            return new FuncionarioCargoViewModel
            {
                Cargo = item.Key.Trim(),
                QtdFuncionarios = item.Value
            };
        }

        public static List<FuncionarioContratoViewModel> ListaFuncionariosPorContrato(Dictionary<string, int> lista)
        {
            var listaVMFuncionarios = new List<FuncionarioContratoViewModel>();
            foreach (var item in lista)
            {
                listaVMFuncionarios.Add(FuncionarioPorContrato(item));
            }
            return listaVMFuncionarios.OrderByDescending(l => l.QtdFuncionarios).ToList();
        }

        public static FuncionarioContratoViewModel FuncionarioPorContrato(KeyValuePair<string, int> item)
        {
            return new FuncionarioContratoViewModel
            {
                Contrato = item.Key.Trim(),
                QtdFuncionarios = item.Value
            };
        }
    }
}

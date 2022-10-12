#pragma checksum "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd7a780844ce48daa226e849a662bb913eedc64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Partials__TabelaFuncionarios), @"mvc.1.0.view", @"/Views/Funcionario/Partials/_TabelaFuncionarios.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\_ViewImports.cshtml"
using WebAppGraficosHighcharts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\_ViewImports.cshtml"
using WebAppGraficosHighcharts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd7a780844ce48daa226e849a662bb913eedc64", @"/Views/Funcionario/Partials/_TabelaFuncionarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a79f3279626ecb7df022d649581c592e18ba6cad", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario_Partials__TabelaFuncionarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppGraficosHighcharts.ViewModel.TabelaFuncionarioViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table id=\"tabela-funcionarios\" class=\"table table-hover table-light\" style=\"width: 100%; \" data-order=\"[]\">\r\n        <thead style=\"width: 100%; white-space:nowrap\">\r\n            <tr>\r\n");
#nullable restore
#line 8 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                 if (Model.FuncionariosEmpresa.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Empresas</th>\r\n                    <th class=\"text-center\">Qtd Funcionários</th>\r\n");
#nullable restore
#line 12 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                }
                else if (Model.FuncionariosCargo.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Cargos</th>\r\n                    <th class=\"text-center\">Qtd Funcionários</th>\r\n");
#nullable restore
#line 17 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Contratos</th>\r\n                    <th class=\"text-center\">Qtd Funcionários</th>\r\n");
#nullable restore
#line 23 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 27 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
             if (Model.FuncionariosEmpresa.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                 foreach (var funcionario in Model.FuncionariosEmpresa)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 32 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                       Write(funcionario.Empresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 33 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                                           Write(funcionario.QtdFuncionarios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                  }

            else if (Model.FuncionariosCargo.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                 foreach (var funcionario in Model.FuncionariosCargo)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 42 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                       Write(funcionario.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 43 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                                           Write(funcionario.QtdFuncionarios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                  }

            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                 foreach (var funcionario in Model.FuncionariosContrato)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 52 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                       Write(funcionario.Contrato);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 53 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                                           Write(funcionario.QtdFuncionarios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 58 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Nenhum registro encontrado</div>\r\n");
#nullable restore
#line 62 "G:\WebAppGraficosHighcharts\WebAppGraficosHighcharts\Views\Funcionario\Partials\_TabelaFuncionarios.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppGraficosHighcharts.ViewModel.TabelaFuncionarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
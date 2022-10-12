using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using WebAppGraficosHighcharts.Models;
using WebAppGraficosHighcharts.Services;

namespace WebAppGraficosHighcharts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public JsonResult BuscarAvaliacoes()
        {
            var listaAvaliacao = AvaliacaoService.BuscarAvaliacoes();
            return Json(listaAvaliacao);
        }

        public IActionResult Index3()
        {
            return View();
        }

        public JsonResult BuscarCidadesPopulosas()
        {
            var listaDePopulacao = PopulacaoService.GetPopulacaoPorEstado();
            return Json(listaDePopulacao);
        }

        public IActionResult Index4()
        {
            var listaAvaliacao = AvaliacaoService.BuscarAvaliacoes();

            var lista = new List<Avaliacao>();
            int totalPessimo = 0, totalRuim = 0, totalIndiferente = 0, totalBom = 0, totalOtimo = 0;

            listaAvaliacao.ForEach(x =>
            {
                totalPessimo += x.Pessimo;
                totalRuim += x.Ruim; totalIndiferente += x.Indiferente;
                totalBom += x.Bom; totalOtimo += x.Otimo;
            });

            var pessimo = totalPessimo;
            var ruim = totalRuim;
            var indiferente = totalIndiferente;
            var bom = totalBom;
            var otimo = totalOtimo;

            lista.Add(new Avaliacao { Pessimo = pessimo, Ruim = ruim, Indiferente = indiferente, Bom = bom, Otimo = otimo });

            return View(lista);
        }

        //public JsonResult BuscarResultadosAvaliacao()
        //{
        //    var listaAvaliacao = AvaliacaoService.BuscarAvaliacoes();
        //    return Json(listaAvaliacao);
        //}




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Avaliacao()
        {
            Highcharts columnChart = new Highcharts("columnchart");
            columnChart.InitChart(new Chart()
            {
                Type = DotNet.Highcharts.Enums.ChartTypes.Column,
                BackgroundColor = new BackColorOrGradient(System.Drawing.Color.AliceBlue),
                Style = "fontWeight: 'bold', fontSize: '17px'",
                BorderColor = System.Drawing.Color.LightBlue,
                BorderRadius = 0,
                BorderWidth = 2
            });
            columnChart.SetTitle(new Title()
            {
                Text = "Santos x São Paulo"
            });
            columnChart.SetSubtitle(new Subtitle()
            {
                Text = "Classificação por pontos no Campeonato Brasileiro"
            });
            columnChart.SetXAxis(new XAxis()
            {
                Type = AxisTypes.Category,
                Title = new XAxisTitle() { Text = "Anos", Style = "fontWeight: 'bold', fontSize: '17px'" },
                Categories = new[] { "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012" }
            });
            columnChart.SetYAxis(new YAxis()
            {
                Title = new YAxisTitle()
                {
                    Text = "Pontos",
                    Style = "fontWeight: 'bold', fontSize: '17px'"
                },
                ShowFirstLabel = true,
                ShowLastLabel = true,
                Min = 0
            });
            columnChart.SetLegend(new Legend
            {
                Enabled = true,
                BorderColor = System.Drawing.Color.CornflowerBlue,
                BorderRadius = 6,
                BackgroundColor = new BackColorOrGradient(ColorTranslator.FromHtml("#FFADD8E6"))
            });
            columnChart.SetSeries(new Series[]
            {
                new Series{
                    Name = "Santos",
                    Data = new Data(new object[] { 89, 59, 64, 62, 45, 49, 53, 53, 57 })
                },
                new Series()
                {
                    Name = "São Paulo",
                    Data = new Data(new object[] { 82, 58, 78, 77, 75, 65, 59, 66, 50 })
                }
            }
            );
            return View(columnChart);
        }
    }
}

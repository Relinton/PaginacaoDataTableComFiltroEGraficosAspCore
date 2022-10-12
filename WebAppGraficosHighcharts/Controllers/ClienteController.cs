using Microsoft.AspNetCore.Mvc;

namespace WebAppGraficosHighcharts.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

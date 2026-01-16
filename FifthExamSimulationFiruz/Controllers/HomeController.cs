using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace FifthExamSimulationFiruz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

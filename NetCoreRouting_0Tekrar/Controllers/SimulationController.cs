using Microsoft.AspNetCore.Mvc;

namespace NetCoreRouting_0Tekrar.Controllers
{
    public class SimulationController : Controller
    {
        public IActionResult SimulationIndex()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MVC_DB.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

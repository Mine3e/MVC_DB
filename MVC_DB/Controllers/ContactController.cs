using Microsoft.AspNetCore.Mvc;

namespace MVC_DB.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

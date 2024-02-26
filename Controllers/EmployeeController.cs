using Microsoft.AspNetCore.Mvc;

namespace EdilCode.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

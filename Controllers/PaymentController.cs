using Microsoft.AspNetCore.Mvc;

namespace EdilCode.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

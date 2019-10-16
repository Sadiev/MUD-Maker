using Microsoft.AspNetCore.Mvc;

namespace Mud_Maker.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Play()
        {
            return View();
        }
    }
}
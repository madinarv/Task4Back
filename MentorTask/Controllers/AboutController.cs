using Microsoft.AspNetCore.Mvc;

namespace MentorTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

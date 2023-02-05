using MentorTask.DataAccessLayer;
using MentorTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentorTask.Controllers
{
    public class TrainersController : Controller
    {
     

        public IActionResult Index()
        {
           return View();
        }
    }
}

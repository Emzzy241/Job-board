using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class JobBoardController : Controller
    {
        [HttpGet("/jobboard")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
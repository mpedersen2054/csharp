using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _21a_SurveyForm
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("results")]
        public IActionResult Submit(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Results");
        }
    }
}
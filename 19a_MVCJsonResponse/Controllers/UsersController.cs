using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _19a_MVCJsonResponse
{
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("users/index")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
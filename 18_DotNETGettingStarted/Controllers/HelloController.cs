using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace _18_DotNETGettingStarted.Controllers
{
    public class Human
    {
        public string name;
        public int height;
        public int weight;
        public Human()
        {
            name = "Fake Person";
            height = 420;
            weight = 224;
        }
    }
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("index")]
        public string index()
        {
            //method body
            return "hello there index routes!!!";
        }

        [HttpGet]
        [Route("getjson")]
        public JsonResult DisplayJson()
        {
            return Json(new Human());
        }

        [HttpGet]
        [Route("morejson")]
        public JsonResult MoreJson()
        {
            var anonObj = new {
                firstName = "Matt",
                lastName = "Pedersen",
                age = 24,
                isCool = true
            };
            return Json(anonObj);
        }
    }
}
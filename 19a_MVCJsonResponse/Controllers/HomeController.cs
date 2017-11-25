using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _19a_MVCJsonResponse
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("{FirstName}/{LastName}/{Age}/{FavColor}")]
        public JsonResult JsonifyInfo(string FirstName, string LastName, string Age, string FavColor)
        {
            var info = new {
                firstName = FirstName,
                lastName = LastName,
                age = Age,
                favColor = FavColor
            };         
            return Json(info);
        }
    }
}
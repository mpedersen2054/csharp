using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _20a_TimeDisplay
{
    public class HomeController : Controller
    {
        public DateTime time;
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // NOTE:
            // Probably should have done it in the view template, but just did it here...
            
            time = DateTime.Now;

            // handle if min < 10, just return string, gonna be rendered on frontend
            string minute = (time.Minute < 10) ? $"0{time.Minute}" : $"{time.Minute}";

            // handle if its pm
            int hour = (time.Hour > 12) ? time.Hour % 12 : time.Hour;
            string month;
            
            // get month Abrv
            string[] months = { 
                "Jan", "Fed", "Mar", "Apr", "May", "Jun", 
                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            month = months[time.Month - 1];

            var Info = new {
                Minute = minute,
                Hour = hour,
                Pref = time.ToString("tt").ToLower(),
                Day = time.Day,
                Month = month,
                Year = time.Year
            };
            ViewData["DateStr"] = $"{Info.Month} {Info.Day}, {Info.Year}";
            ViewData["TimeStr"] = $"{Info.Hour}:{Info.Minute} {Info.Pref}";
            return View("Index");
        }
    }
}
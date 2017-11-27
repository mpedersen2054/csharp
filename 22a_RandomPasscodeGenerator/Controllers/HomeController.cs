using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _22a_RandomPasscodeGenerator
{
    public class HomeController : Controller
    {
        public Random random = new Random();
        private string AlphaNumer = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string GenCode()
        {
            string retStr = "";
            for (var i = 0; i < 13; i++)
            {
                char randChar = AlphaNumer[random.Next(AlphaNumer.Length)];
                retStr += randChar;
            }
            return retStr;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // if there is nothing attempts then generate code
            int? Attempts = HttpContext.Session.GetInt32("Attempts");
            string Passcode = HttpContext.Session.GetString("Passcode");
            if (Attempts == null || Passcode == null)
            {
                HttpContext.Session.SetInt32("Attempts", 1);
                HttpContext.Session.SetString("Passcode", GenCode());
            }
            ViewData["Attempts"] = HttpContext.Session.GetInt32("Attempts");
            ViewData["Passcode"] = HttpContext.Session.GetString("Passcode");
            return View("Index");
        }

        [HttpGet]
        [Route("generate_new")]
        public IActionResult GenerateNew()
        {
            int? CurrentAttempts = HttpContext.Session.GetInt32("Attempts");
            int Value = CurrentAttempts.Value;
            HttpContext.Session.SetInt32("Attempts", Value + 1);
            HttpContext.Session.SetString("Passcode", GenCode());
            return RedirectToAction("Index");
        }
    }
}
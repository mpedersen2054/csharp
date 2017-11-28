using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PokeApiInfo.Helpers;
using PokeApiInfo.Models;

namespace PokeApiInfo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("pokemon/{Pid}")]
        public JsonResult GetPokemonData(string Pid)
        {
            int PokeId = Convert.ToInt32(Pid);
            Pokemon Poke = new Pokemon();
            if (Cache.PokemonExists(PokeId))
            {
                Poke = Cache.GetPokemon(PokeId);
            }
            else
            {
                ApiWrapper.GetPokemonDataAsync(PokeId, ApiResponse => {
                    Poke = ApiResponse;
                }).Wait();
            }
            System.Console.WriteLine($"Pokemon id: {Pid}");
            return Json(Poke);
        }
    }
}

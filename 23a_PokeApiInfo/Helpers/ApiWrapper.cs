using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using PokeApiInfo.Models;

namespace PokeApiInfo.Helpers
{
    public class ApiWrapper
    {
        private static string UriBase = "http://pokeapi.co/api/v2";
        // asyncronously request data from pokemon API
        public static async Task GetPokemonDataAsync(int PokeId, Action<Pokemon> Callback)
        {
            // Cache checking happens in Controller
            using (var Client = new HttpClient())
            {
                try
                    {
                        Client.BaseAddress = new Uri($"{UriBase}/pokemon/{PokeId}"); // Base stats
                        HttpResponseMessage Response = await Client.GetAsync("");
                        Response.EnsureSuccessStatusCode(); // Throw Err if not successful
                        string StringResponse = await Response.Content.ReadAsStringAsync();
                        // Use class Pokemon to get the data needed
                        Pokemon NewPokemon = JsonConvert.DeserializeObject<Pokemon>(StringResponse);
                        Cache.AddPokemon(PokeId, NewPokemon);
                        Callback(NewPokemon);
                    }
                    catch (HttpRequestException err)
                    {
                        // Something went wrong
                        Console.WriteLine($"Request exception: {err.Message}");
                    }
            }
            // Cache.AddPokemon(PokeId);
        }
    }
}
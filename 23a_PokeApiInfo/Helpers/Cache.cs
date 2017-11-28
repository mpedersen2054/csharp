using System;
using System.Collections.Generic;
using PokeApiInfo.Models;

namespace PokeApiInfo.Helpers
{
    public class Cache
    {
        public static Dictionary<int,Pokemon> Items = new Dictionary<int,Pokemon>();

        public static bool PokemonExists(int PokeId)
        {
            return (Items.ContainsKey(PokeId)) ? true : false;
        }

        public static void AddPokemon(int PokeId, Pokemon Poke)
        {
            System.Console.WriteLine("Adding pokemon to Cache...");
            Items[PokeId] = Poke;
        }

        public static Pokemon GetPokemon(int PokeId)
        {
            System.Console.WriteLine("Getting Pokemon from Cache...");
            return Items[PokeId] as Pokemon;
        }
    }
}
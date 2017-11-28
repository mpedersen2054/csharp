using System;
using System.Collections.Generic;

namespace PokeApiInfo.Models
{
    // used in Deserialize<Pokemon> to destructure the Json data
    public class Pokemon
    {
        public int Id;
        public string Name;
        public Dictionary<string,object>[] Types;
        public Dictionary<string,string> Sprites;
        public Dictionary<string,object>[] Stats;
        // add more here to make use of data recieved from Json Response...
    }
}
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPokemon.Models
{
    public class PokemonListAPIModel : APIModel
    {
        // { Message: "OK", Result: [{},{}] }
        public System.Collections.Generic.List<PokemonModel> Result { get; set; }
    }

    public class PokemonAPIModel : APIModel
    {
        // { Message: "OK", Result: {} }
        public PokemonModel Result {get; set; }
    }
}
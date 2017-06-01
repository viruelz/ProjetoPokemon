using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPokemon.Models
{

    public class UsuarioAPIModel : APIModel
    {
        // { Message: "OK", Result: {} }
        public UsuarioModel Result { get; set; }
    }
}
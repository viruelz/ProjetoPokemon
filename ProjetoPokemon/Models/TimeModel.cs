using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPokemon.Models
{
    public class TimeListAPIModel : APIModel
    {
        // { Message: "OK", Result: [{},{}] }
        public System.Collections.Generic.List<TimeModel> Result { get; set; }
    }

    public class TimeAPIModel : APIModel
    {
        // { Message: "OK", Result: {} }
        public TimeModel Result { get; set; }
    }
}
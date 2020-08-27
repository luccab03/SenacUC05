using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AT03.Models
{
    public class Consulta
    {
        public string Nome {get; set;}

        public string Telefone {get; set;}
    
        public DateTime Data {get; set;}

        public string Animal {get; set;}

        public string Desc {get; set;}
    }
}
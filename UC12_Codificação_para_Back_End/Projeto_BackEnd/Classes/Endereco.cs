using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_BackEnd.Classes
{
    public class Endereco
    {
        public string? logradouro {get; set;}

        public int numero {get; set}

        public string? complement {get; set;}

        public bool? endComercial {get; set;}
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_BackEnd;

namespace Projeto_BackEnd.Classes
{
    public class Pessoa : IPessoa
    {   
        public string? nome {get; set;}

        public string? endereco {get; set;}

        public float? rendimento {get; set;}

        public float CalcularImposto(float rendimento)
        {
            //throw new NotImplementeException();
        }
    }
}
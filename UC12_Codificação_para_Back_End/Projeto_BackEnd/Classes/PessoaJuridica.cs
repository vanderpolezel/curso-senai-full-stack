using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_BackEnd;

namespace Projeto_BackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set;}

        public bool ValidarCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}
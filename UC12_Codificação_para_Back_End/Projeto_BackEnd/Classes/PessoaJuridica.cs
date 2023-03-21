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

        public override float CalcularImposto(float rendimento)
        {   
             if(rendimento <= 1500)
            {
                float resultado = rendimento * .03f;
                return 0;
            } else if(rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = rendimento * 0.02f;
                return resultado;

            } else if(rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = rendimento * 0.07f;
                return resultado;

            } else (rendimento > 1500 && rendimento <= 6000)
            {
                 float resultado = rendimento * 0.09f;
                return resultado;
                
            }

            throw new NotImplementedException();
        }

        public bool ValidarCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}
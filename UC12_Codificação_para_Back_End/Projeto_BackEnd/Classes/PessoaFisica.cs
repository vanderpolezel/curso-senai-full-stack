using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_BackEnd;

namespace Projeto_BackEnd.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get; set;}

        public DateTime dataNas {get; set;}

        public override float CalcularImposto(float rendimento)
        {   
            
            if(rendimento <= 1500)
            {
                return 0;
            } else if(rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento/ 100) * 2;
                return resultado;

            } else if(rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento/ 100) * 2;
                return resultado;

            } else (rendimento > 1500 && rendimento <= 6000)
            {
                 float resultado = (rendimento/ 100) * 5;
                return resultado;
                
            }

        }

        public bool ValidarDataNasc(string dataNasc)
        // Validar a maioridade da data de nascimento
        {
            if (DateTime.TryParse(dataNasc, out DateTime dataConvertida))
            {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataNas - dataAtual).TotalDays / 365;

            Console.WriteLine(anos);

            if(anos >= 18) 
            {
                return true;
            }

            return false;

        }

            public bool ValidarDataNasc(string dataNasc) 
    {

        if (DateTime.TryParse(dataNasc, out DateTime dataConvertida));


        throw new NotImplementedException();
    }
    }
}
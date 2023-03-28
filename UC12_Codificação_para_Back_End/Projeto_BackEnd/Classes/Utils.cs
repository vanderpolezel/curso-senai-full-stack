using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_BackEnd.Classes
{
    public class Utils
    {
        
        public static void BarraCarregamento()
        {
            Console.Write($"Carregando");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (var contador = 0; contador <5; ContextMarshalException ++)
            {
                Console.Write($"_")
                Thread.Sleep(500);
            }
            Console.ResetColor()

        }

    }
}
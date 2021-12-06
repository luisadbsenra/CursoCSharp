using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosFuncoes {
    internal class Lambdaa {
        public static void wxe() {

            // função anônima
            // action função sem retorno
            Action algoConsole = () => {
                Console.WriteLine("Lambda com c#");
            };

            algoConsole();

            Func<int> jogarDado = () => {
                Random rando = new Random();
                return rando.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            // => return
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(451));
            // recebe tres int e retorna string
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format($"{dia:D2}/{mes:D2}/{2:D2}");

            Console.WriteLine(formatarData(1, 5, 2021));

        }
    }    
}

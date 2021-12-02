using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class dowhile {
        public static void ece() {
            // o código vai ser executado

            string resp;
            do {
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine($"Seja bem-vindo {nome}");

                Console.WriteLine("Quer continuar?");
                resp = Console.ReadLine();
                

            } while (resp == "S" || resp == "s");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class fforeach {
        public static void name() {
            string palavra = Console.ReadLine();

            // cada vez que executar vai ser para uma letra da palavra
            foreach(var letra in palavra) {
                Console.WriteLine(letra);
            }


            var name = new string[] { "Ana", "Laia", "Sina", "Vivian" };
            foreach (string aluno in name) {
                Console.WriteLine(aluno);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class wwhile {
        public static void exe() {
            int palpite = 0;
            Random rando = new Random();

            // 1 a 15
            int nScrt = rando.Next(1, 16);
            bool nEnc = false;
            int vezes = 0;
            int tentaivas = 5;

            while (tentaivas > 0 && !nEnc) {
                Console.WriteLine("Palpilte");
                string ent = Console.ReadLine();
                int pass = int.Parse(ent);

                tentaivas--;
                vezes++;

                if (nScrt == pass) {
                    nEnc = true;
                    var corAnt = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Numero encontrado em {0} tentativas restantes");
                    Console.BackgroundColor = corAnt;
                } else if (pass > nScrt) {
                    Console.WriteLine("Maior. Tente Novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentaivas);
                } else {
                    Console.WriteLine("Menor, vai de novo");
                    Console.WriteLine("Tentativas restantes: {0}",tentaivas);
                }

                // laço infinito
                while (true) {

                }
            }
        }
    }
}

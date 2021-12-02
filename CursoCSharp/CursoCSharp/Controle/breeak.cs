using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class breeak {
        public static void bb() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"O número que queremos é {numero}");
            for (int i = 1; i <= 50; i++) {

                Console.WriteLine($"{i} é o numero que queremos?");
                if (i == numero) {
                    Console.WriteLine("Sim");
                    break;
                } else {
                    Console.WriteLine("Não!");

                }

            }
            Console.WriteLine("");


        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class Elif {
        public static void dodo() {
            Console.WriteLine("Nota");
            string ent = Console.ReadLine();
            Double.TryParse(ent, out double saida);

            if (saida >= 9) {
                Console.WriteLine("Bom");
            } else if (saida >= 7) {
                Console.WriteLine("Aprovado");
            } else if (saida >= 5) {
                Console.WriteLine("Rec");
            } else {
                Console.WriteLine("End Game");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void realizar() {
            double n = 15.75698;
            // arrendodar para 1 casa decimal
            Console.WriteLine(n.ToString("F1"));
            // para moeda
            Console.WriteLine(n.ToString("C"));
            // porcentagem
            Console.WriteLine(n.ToString("P"));
            // colocar casas decimais again
            Console.WriteLine(n.ToString("#.##"));

            int inteiro = 256;
            // completa até ter 10 caracteres
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}

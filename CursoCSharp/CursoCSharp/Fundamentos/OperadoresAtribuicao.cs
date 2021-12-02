using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class OperadoresAtribuicao {
        public static void exe() {
            var n1 = 3;
            n1 = 2; // substituiçaõ
            // atribuição
            n1 += 10;
            Console.WriteLine(n1);
            n1 -= 3;
            Console.WriteLine(n1);
            n1 *= 5;
            Console.WriteLine(n1);
            n1 /= 2;
            Console.WriteLine(n1);


            int a = 1, b = a;


            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";
            dynamic d = c;
            d.nome = "Maria";



        }
    }
}

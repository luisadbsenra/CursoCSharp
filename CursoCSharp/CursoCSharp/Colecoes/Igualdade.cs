using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Igualdade {
        public static void ex() {
            var p1 = new Produto("Cantea", 1.78);
            var p2 = new Produto("Cantea", 1.78);
            var p3 = p2;

            // compara endereço de memoria
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);
            Console.WriteLine(p1.Equals(p2));



        }
    }
}

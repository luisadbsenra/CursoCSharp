using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class OperadoresUnários {
         public static void dotex() {
            var valNeg = -5;
            var n1 = 7;
            var n2 = 8;
            var boolean = true;

            Console.WriteLine(-valNeg);
            Console.WriteLine(!boolean);

            // incremento 
            n1++;

            // decremento
            n1--;

            //--n2 antes da comparação
            Console.WriteLine(n1++ == n2--);

            Console.WriteLine($"{n1} {n2}");


        }
    }
}

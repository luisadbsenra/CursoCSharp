using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosFuncoes {
    internal class DelPar {

        public delegate int Op(int x, int y);
        public static int Soma(int x, int y) {
            return x + y;
        }

        public static string Calculadora(Op op, int x, int y) {
            var res = op(x, y);
            return "Resultado: " + res;
        }

        public static void Exe() {
            Op sub = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(sub, 3, 2));
            // como eles tem os mesmo parametros, funcionam
            Console.WriteLine(Calculadora(Soma, 3, 2));
           
        }
    }
}

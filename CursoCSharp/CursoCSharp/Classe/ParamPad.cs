using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {
    internal class ParamPad {
        // parãmetro padrão
        public static int Somar(int a = 1, int b = 2) {
            return a + b;
        }
        public static void Exe() {
            Console.WriteLine(Somar(4,3));
            Console.WriteLine(Somar(3));
            Console.WriteLine(Somar(b: 4));
        }

    }
}

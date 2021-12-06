using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosFuncoes {

    public static class ExtensoesInt {
        public static int Soma(this int num, int outro) {
            return num + outro;
        }

        public static int Sub(this int num, int outro) {
            return num - outro;
        }
    }

    internal class MetodoExt {
        public static void Exe() {
            int nume = 5;
            Console.WriteLine(nume.Soma(5));
            Console.WriteLine(nume.Sub(5));
            Console.WriteLine(nume.Soma(78));

        }
    }
}

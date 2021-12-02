using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class ParamNo {
        public static void Exe() {
            Forma(mes: 1, dia: 6, ano: 1996);
        }

        public static void Forma(int dia, int mes, int ano) {
            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");
        }
    }
    
}

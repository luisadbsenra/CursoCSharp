using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {
    
    public class CalculadoraEstatia {
        public static int Somar(int a, int b) {
            return a + b;
        }

        public int Mult(int a, int b) {
            return a * b;
        }

        // o método que não tem a palavra static, não consegue ter acesso ao método sem ter uma instânciaa

    }

    internal class MetodosEstaticos {
        public static void Exe() {
            var cal = new CalculadoraEstatia();
            Console.WriteLine(CalculadoraEstatia.Somar(5,9));
            Console.WriteLine(cal.Mult(7, 4));

        }
    }
}

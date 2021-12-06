using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    interface Teste {
        bool te(string a);
    }

    // várias classes podem implementar essa interface
    interface OpeBin {
        // por padrão public
        int Operacao(int a, int b);
    }

    class Soma : OpeBin, Teste {
        public int Operacao(int a, int b) {
            return a + b;

        }

        public bool te(string teste) {
            return true;
        }
    }

    class Subb : OpeBin {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Multi : OpeBin {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Div : OpeBin {
        public int Operacao(int a, int b) {
            return a / b;
        }
    }

    class Cauculadora {
        List<OpeBin> ope = new List<OpeBin> {
            new Soma(),
            new Subb(),
            new Multi(),
            new Div()
        };

         public string ExecutarOp(int a, int b) {
            string result = "";
            foreach(var op in ope) {
                result += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
                
            }
            return result;
         }

    }   

    internal class Interfacew {
        public static void Exe() {
            var calc = new Cauculadora();
            var res = calc.ExecutarOp(20, 6);
            Console.WriteLine(res);
        }
    }
}

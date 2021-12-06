using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ErroExc {

    public class NegativoException : Exception{
        public NegativoException() { }
        public NegativoException(string mesagem) : base(mesagem) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparE : Exception {
        public ImparE(string message) : base(message) { }
    }

    internal class ExecoesPerso {
        public static int PositivoPar() {
            Random rando = new Random();
            int valor = rando.Next(-30, 30);

            if(valor < 0) {
                throw new NegativoException("número negativo...");
            }

            if (valor% 2 == 1) {
                throw new ImparE("número negativo...");
            }

            return valor;
        }
        public static void Exec() {
            try {
                Console.WriteLine(PositivoPar());
            } catch(NegativoException ex) {
                Console.WriteLine(ex.Message);
            } catch(ImparE ex) {
                Console.WriteLine(ex.Message);
            }              
        }
    }
}

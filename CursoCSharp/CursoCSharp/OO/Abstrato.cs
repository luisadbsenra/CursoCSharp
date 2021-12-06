using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    // não consegue estânciar -  abstrato
    public abstract class Celular {
        // método não se implementa
        public abstract string Assitente();

        // método se implemeta
        public string Tocar() {
            return "Sons";
        }
    }
    internal class Abstrato {
        public static void Abs() {
            var celulares = new List<Celular> {
                new Apple(),
                new Samsung()
            };
            
            foreach(var celular in celulares) {
                Console.WriteLine(celular.Assitente());
            }

        }

       
    }

    public class Samsung : Celular {
        public override string Assitente() {
            return "Bixby";
        }
    }


    public class Apple : Celular {

        // reescrevendo o método abstrato da 
        public override string Assitente() {
            return "Siri";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }
        public Comida() {

        }
    }

     public class Arroz : Comida {
       public double Peso;
     }

     public class Feijao : Comida {
       public double Peso;
     }

    public class Carne : Comida {
        public double Peso;
    }
    
    public class Pessoa {
        public double Peso;

        //public void Comer(Feijao feijao) {
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }

    internal class Polimorfismo {
        public static void Exe() {
            Feijao ingredientes1 = new Feijao();
            ingredientes1.Peso = 0.3;

            Arroz i2 = new Arroz();
            i2.Peso = 0.40;

            Carne i3 = new Carne();
            i3.Peso = 0.44;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingredientes1);
            cliente.Comer(i2);
            cliente.Comer(i3);

            Console.WriteLine($"Peso atual é {cliente.Peso}");

        }
    }
}

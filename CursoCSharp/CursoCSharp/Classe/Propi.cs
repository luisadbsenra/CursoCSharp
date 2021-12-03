using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class Propi {
        public static void Ex() {
            var op1 = new CarroOpcional("Ar Condicional", 2547.2);
            Console.WriteLine($"{op1.Nome} {op1.Preco}");
        }
    }

    public class CarroOpcional {
        // private - não precisa declarar
        // propiedade - é privada
        double desconto = 0.1;
        string nome = "";
         
        public string Nome {
            get {
                return "Opcional: " + nome;
            }

            set {
                nome = value;
            }

        }

        //propiedade autoimplementada
        public double Preco { get; set; }


        // somente leitura
         public double PrecoDesconto {
            get => Preco - (desconto * Preco); // lambda - forma reduzida
         }

        // construtores
        public CarroOpcional() {

        }

        // construtores
        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
}


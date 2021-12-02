using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {

    public class Produto {
        public string Nome;
        public double Preco;
        // atributo de classe
        public static double Desconto = 0.1;

        public Produto() {


        }

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }


        public double Desc() {
            return Preco - Preco * Desconto;
        }

    }
    internal class AtributoEstatico {
        public static void Exe() {
            var p1 = new Produto("Caneta", 3.2, 0.1);
            var p2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
                
            };

            Produto.Desconto = 0.5;

            Console.WriteLine($"Preco com desconto: {p1.Desc()}");
            Console.WriteLine($"Preco com desconto: {p2.Desc()}");

        }
    }
}

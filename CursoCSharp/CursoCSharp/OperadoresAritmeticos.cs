using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class OperadoresAritmeticos {
        public static void made() {
            // preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var deconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - total * deconto;
            Console.WriteLine("O preco final é {0}", totalDesconto);

            // IMC
            double peso = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // par e impar
            int par = 24, impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);



        }
    }
}

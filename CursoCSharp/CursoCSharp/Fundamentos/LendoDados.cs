using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void doo() {
            Console.Write("Nome: ");
            // ler variável
            string nome = Console.ReadLine();
            
            Console.Write("Idade: ");
            // conversão
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Salario: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} R${salario}.");

        }
    }
}

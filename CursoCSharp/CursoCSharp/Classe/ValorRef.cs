using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {

    public class Dependente {
        public string Nome;
        public int Idade;
    }
    internal class ValorRef {
        public static void ec() {
            int n = 3;
            int copia = n;
            Console.WriteLine(n);
            Console.WriteLine(copia);

            n++;
            Console.WriteLine(n);
            Console.WriteLine(copia);

            var dep = new Dependente();
            dep.Nome = "Beto";
            dep.Idade = 25;

            Dependente depcopia = dep;
            Console.WriteLine($"{dep.Nome} {dep.Idade}");

            depcopia.Nome = "Naldjm";

            Console.WriteLine($"{dep.Nome} {dep.Idade}");



        }
    }
}

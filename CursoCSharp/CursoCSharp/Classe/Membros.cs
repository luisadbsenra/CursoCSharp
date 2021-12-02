using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {
    internal class Membros {
        public static void ex() {
            Pessoa pessu = new Pessoa();
            pessu.Nome = "Noah";
            pessu.Idade = 19;
                   
            //  Console.WriteLine($"{pessu.Nome} tem {pessu.Idade} anos.");

            pessu.ApresentarConsole();
            var pes = new Pessoa();
            pes.Idade = 15;
            pes.Nome = "Josh";
            var ap = pes.Apresentar();
             
        }
    }
}

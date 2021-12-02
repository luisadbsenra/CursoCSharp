using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {
    internal class Pessoa {
        public string Nome;
        public int Idade;
    public string Apresentar() {
        return String.Format($"Ólá meu no {Nome} tem {Idade} anos.");
    }
        public void ApresentarConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }

    
}

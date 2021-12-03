using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {

    public class Cliente {
        public string Nome;
        // só consegue ler o arquivo
        readonly DateTime Nascimento;


        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }
        public Cliente() {

        }
       
        public string nome { set; get; }
        public string data {

            get {
                return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
            }

        }

    }

    internal class Readonly {

        public static void Executar() {

            // com as variaveis
            var novo = new Cliente("Ana Ana -", new DateTime(1987, 5, 11));
            Console.WriteLine($"{novo.Nome} {novo.data}");


            // public cliente so
            var novo2 = new Cliente();
            novo2.nome = "luisa";
            Console.WriteLine(novo2.nome);

        }
    }
}



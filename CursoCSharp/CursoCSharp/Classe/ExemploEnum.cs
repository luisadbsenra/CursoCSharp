using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {

    // conjunto fechado, enumeração
    public enum Genero {Acao, Aventura, Terro, Animacao, Comedia}

    public class Filme {
        public string Titulo;
        public Genero GeneroFilme;
    }
    
    internal class ExemploEnum {            
        public static void executar() {
            int id = (int)Genero.Aventura;
            Console.WriteLine(id);

            var familia = new Filme();
            familia.Titulo = "Filme";
            familia.GeneroFilme = Genero.Comedia;

            Console.WriteLine($"{familia.Titulo} é {familia.GeneroFilme}");
            
        }
    }
}

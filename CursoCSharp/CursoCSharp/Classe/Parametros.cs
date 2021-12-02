using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {
    internal class Parametros {
        public static void Recpcionar(params string[] pessoas) {
            foreach(var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");
            }
        }
        public static void exe() {
            Recpcionar("Pedro", "Manu", "Alguém");
        }
    }
}

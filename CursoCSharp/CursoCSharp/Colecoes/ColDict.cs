using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColDict {
        public static void Exe() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Some");
            filmes.Add(2010, "Somesd");
            filmes.Add(2018, "Somev");
            filmes.Add(2004, "Somee");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);

            }
        }
        

    }
}

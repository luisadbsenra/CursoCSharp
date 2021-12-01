using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
      public static void fazer() {
            var saudacao = "olá".ToUpper(); // todas letra maiuscula
            var saudacao1 = "olá".ToUpper().Insert(3, " World!"); // todas letra maiuscula + substituição (3 posição de palavras)
            var saudacao2 = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!"); // todas letra maiuscula + substituição + trocar

            Console.WriteLine(saudacao);
            Console.WriteLine(saudacao1);
            Console.WriteLine(saudacao2);

            string valorImportante = null;
            // usar a notação . em valor vazio é problema
            Console.WriteLine(valorImportante?.Length);
            // caso der erro o ? faz com que não deixe ocorrer um erro 
        } 
    }
}

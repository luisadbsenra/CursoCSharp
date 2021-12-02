using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class UsingIfElse {
        public static void executar() {
            String comportamento = "";
            float nota = 0;

            Console.WriteLine("Bom comportamento? (S/N)");
            comportamento = Console.ReadLine();
            Console.WriteLine("Nota:");
            nota = float.Parse(Console.ReadLine());


            if ((comportamento == "S" || comportamento == "s") && nota > 7) {
                Console.WriteLine("bom");
            } else {
                Console.WriteLine("mal");
            }
        }
    }
}

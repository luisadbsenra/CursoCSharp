using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTenario {
        public static void opdot() {
            var nota = 7;
            bool comportamento = true;
            // if e else reduzido
            var res = nota >= 7 && comportamento ? "Aprovado " : "Reprovado";
            Console.WriteLine(res);
        }
    }
}

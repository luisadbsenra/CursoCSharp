using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLógicos {
        public static void DO() {
            var etrab1 = true;
            var etrab2 = false;

            bool comproTv = etrab1 && etrab2;
            Console.WriteLine("Comprou? {0}", comproTv);

            bool comproIce = etrab1 || etrab2;
            Console.WriteLine("Comprou? {0}", comproIce);

            bool comproTv2 = etrab1 ^ etrab2;
            Console.WriteLine("Comprou TV2? {0}", comproTv2);

            Console.WriteLine("Saudável? {0}", !comproIce);


            

        }
    }
}

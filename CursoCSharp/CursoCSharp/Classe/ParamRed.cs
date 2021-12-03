using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {
    internal class ParamRed {

        // passabdi um dado com a referência lá de baixo e ele volta depois mudado
        public static void Alterar(ref int nu) {
            nu = nu + 1000;

        }

        public static void Alt(out int nu) {
            nu = 0;
            nu = nu + 15;
        }


        public static void Som() {
            int a = 3;
            Alterar(ref a);
            Console.WriteLine(a);
            // out é inudireessional, ou seja, ele é só jogado fora, sendo inciliazado dentro da função
            
            Alt(out int b);
            Console.WriteLine(b);

        }
    }
}

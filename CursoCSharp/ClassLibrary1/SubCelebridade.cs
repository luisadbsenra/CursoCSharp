using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace Encapsulamento {
     public class SubCelebridade {
        //todos
        public string InfoPubliva = "Tenho um instagram!";

        //herança
        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCel = 5511999999999;

        // herança ou mesmo projeto
        protected internal string JeitodeFalar = "Uso de gírias";

        // mesma class e ou herança no mesmo projeto 
        private protected string SegredoFamilia = "bla bla";

        //priate padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPubliva);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCel);
            Console.WriteLine(JeitodeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
     }
}

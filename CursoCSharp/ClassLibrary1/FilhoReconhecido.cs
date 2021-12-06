using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace Encapsulamento {
   class FilhoReconhecido : SubCelebridade {

        public new void MeusAcessos() {
            Console.WriteLine("Filho Reconhecido...");

            Console.WriteLine(InfoPubliva);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCel);
            Console.WriteLine(JeitodeFalar);
            Console.WriteLine(SegredoFamilia);
           
        }
   }
}
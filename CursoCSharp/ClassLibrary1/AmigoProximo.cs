using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace Encapsulamento {
    internal class AmigoProximo {

        // como não é herança, precisa instanciar

        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine("Amigo Proximo....");
            Console.WriteLine(amiga.InfoPubliva);
            Console.WriteLine(amiga.JeitodeFalar);
            
        }
    }
}

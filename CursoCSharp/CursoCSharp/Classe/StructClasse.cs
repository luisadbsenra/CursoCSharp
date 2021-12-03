using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe { 
    public struct SPonto {
       public int x;
       public int y;
    }

    public class CPonto {
       public int x;
       public int y;
    }

    internal class StructClasse {
       
        public static void Exe() {
            // struct é por copia, não referêcia
            SPonto p1 = new SPonto { x = 4, y = 7 };
            SPonto copiap1 = p1;

            p1.x = 3;

            Console.WriteLine(p1.x);
            Console.WriteLine(copiap1.x); // atribuição por valor - não geara consequencias

            CPonto p2 = new CPonto { x = 7, y = 9 };
            CPonto copia2 = p2; // atribuição por referencia
            // muda os filiados tbm
            p2.x = 8;

            Console.WriteLine(p2.x);
            Console.WriteLine(copia2.x);
        }
       
    }
}

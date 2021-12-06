using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    // não permiti herança
    sealed class SemFilho { 
        public double ValorFort() {
            return 1_407_444.6;
        }
    }
    internal class Sealed {
        public static void A() {

            SemFilho s = new SemFilho();
            Console.WriteLine(s.ValorFort());

            FR f = new FR();
            Console.WriteLine(f.HonrarNomeFamilia());

        }
    }

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonrarNomeFamilia() {
            return true;
        }
    }

     class FR : Pai {

    }


}

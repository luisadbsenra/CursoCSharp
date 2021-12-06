using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosFuncoes {
    internal class DelAno {
        delegate string stringOpe(string s);

        public static void exeee() {
            stringOpe inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new String(charArray);
            };

            Console.WriteLine(inverter("C# é show!!"));
        }
    }
}

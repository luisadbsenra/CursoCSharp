using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class ArrayLista {
        public static void exe() {
            var arraylist = new ArrayList {
                "palavra",
                3,
                true
            };

            arraylist.Add(3.15);

            foreach(object item in arraylist) {
                Console.WriteLine($"{item} => {item.GetType()}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// FIFO
namespace CursoCSharp.Colecoes {
    internal class FilaQueue {
        public static void Exe() {
            var fila = new Queue<string>();
            //adidionar
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicr");
            fila.Enqueue("Fino");

            // primeiro a "ser atendido"
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }


            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            // contém na fila
            Console.WriteLine(salada.Contains("Item"));

        }
    }
}

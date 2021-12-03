using System;
using System.Collections;

using System.Text;


namespace CursoCSharp.Colecoes {
    internal class aStack {
        public static void exe() {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }

            // LIFO (push add) (pop delete)

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach(var item in pilha) {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");

        }

    }
}

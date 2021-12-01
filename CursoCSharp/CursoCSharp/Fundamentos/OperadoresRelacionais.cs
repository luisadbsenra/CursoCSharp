using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void fazer() {
            // double nota = 6.0;
            Console.Write("Digite a nota:");
            double.TryParse(Console.ReadLine(), out double nota); 
            double notaDeCorta = 7.0;
            Console.WriteLine("Nota Inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota Inválida? {0}", nota < 0.0);
            Console.WriteLine("Nota Inválida? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorta);
            Console.WriteLine("Passou por média? {0}", nota < notaDeCorta);
            Console.WriteLine("Reprovado (a)? {0}", nota <= 3.0);
            
        }
    }
}

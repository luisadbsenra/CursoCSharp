using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class foor {
        public static void doda() {
            // int i = 1;

            // declaraçaão - expressão - contador

            double sum = 0;
            string entrada;

            Console.WriteLine("Tamanho da Turma");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.WriteLine($"Nota do Aluno {i}");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                sum += notaAtual;

            }

            double media = tamanhoTurma > 0 ? sum / tamanhoTurma : 0;
            Console.WriteLine("Media da Turma: {0}", media);
        }
    }
}

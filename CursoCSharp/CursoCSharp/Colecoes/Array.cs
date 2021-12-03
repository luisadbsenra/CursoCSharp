


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class AArray {
        public static void exe() {

           // tipo[] nome = new tipo[tamanho]
           // estrutura estática e homogênia - mesmos dados e não adiciona
            string[] alunos = new string[5];
            alunos[0] = "um";
            alunos[1] = "dois";
            alunos[2] = "tres";
            alunos[3] = "quatro";
            alunos[4] = "cinco";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 2.1, 4.9, 4.1, 6.2, 2.3};

            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length; 
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'd', 'w', 'i' };
            // juntou
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
        
    }
}

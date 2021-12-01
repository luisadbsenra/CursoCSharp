using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstate {
        public static void variaveis() {
            // area da circuferência

            // tipo nome =(atribuição) valor
            double raio = 4.5;
            const double PI = 3.1415;

            raio = 5.5;
            // PI = 2;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area + 1000); // concatenação
            Console.WriteLine("A área é " + (area + 1000)); // adição 


            bool Chuva = false;
            Console.WriteLine("Está chovendo " + Chuva);

            byte idade = byte.MaxValue;
            Console.WriteLine(idade);

            sbyte salDeGols = sbyte.MinValue; // -127 até 127
            Console.WriteLine("sbyte: " + salDeGols);

            short salario = short.MaxValue; // até 32767
            Console.WriteLine("short: " + salario);

            int menorValorint = int.MinValue; // mihões
            Console.WriteLine("int: " + menorValorint);

            uint populacao = 207_607_000; // sem sinaç e o _ separa milhares
            Console.WriteLine("unit: " + populacao);

            long menorLong = long.MinValue;
            Console.WriteLine("Long: " + menorLong);

            // o u é para não ter sinal 

            // tem quer colocar o f no final
            float preco = 1299.54f;

            // o double tem o dobro de capacidade
            double valor = 1_000_000_000_000.515045258;

            char letra = 'b';

            string texto = "Texto texto texto texto";




        }
    }
}

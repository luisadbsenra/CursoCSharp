using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {


    class CalculadoraComum {
        float a, b;
        public float Somar(float a, float b) {
            return a + b;
        }
        public float Diferenca(float a, float b) {
            return a - b;
        }
        public float Dividir(float a, float b) {
            return a / b;
        }
        public float Multiplicar(float a, float b) {
            return a * b;
        }
    }


    public class CalculdoraCadeia {
        int memoria;

        // retorna a mesma classe
        public CalculdoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculdoraCadeia Mult(int a) {
            memoria *= a;
            return this;
        }

        public CalculdoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculdoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Result() {
            return memoria;
        }
    }

    internal class MetodosRetorno {
        public static void Exe() {
            var cal = new CalculadoraComum();
            float s = cal.Somar(1, 6);
            float m = cal.Multiplicar(1, 6);
            float d = cal.Diferenca(6, 1);
            float dv = cal.Dividir(6, 1);

            //Console.WriteLine(s);
            //Console.WriteLine(d);
            //Console.WriteLine(m);
            //Console.WriteLine(dv);

            var calculadoraCadeia = new CalculdoraCadeia();

           // calculadoraCadeia.Somar(3).Mult(4).Imprimir();



        }
    }
}

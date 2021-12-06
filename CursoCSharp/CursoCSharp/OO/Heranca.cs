using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro (int velocidaM) {
            VelocidadeMaxima = velocidaM;
        }

        protected int AlterarVelocidade(int delta) {

            int novaV = VelocidadeAtual + delta;
            if (novaV < 0) {
                VelocidadeAtual = 0;
            } else if (novaV > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeAtual;
            } else {
                VelocidadeAtual = novaV;
            }

            return VelocidadeAtual; 
        }

        // virtual - pode ser sobreescrito
        public virtual int Acelarar() {
            return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro {
        
        // chama o construtor base - velocidade máxima 
        public Uno() : base(200){

        }
    }

    public class Ferari : Carro {
        public Ferari() : base(450) {

        }

        // override - sobrencrevendo 
        public override int Acelarar() {
            return AlterarVelocidade(15);
        }

        // oculta o metéodo - só funciona no tipo Ferrari                                          
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }

    internal class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno..");
            Uno c1 = new Uno();
            Console.WriteLine(c1.Acelarar());
            Console.WriteLine(c1.Acelarar());
            Console.WriteLine(c1.Frear());
            Console.WriteLine(c1.Frear());
            Console.WriteLine(c1.Frear());

            Console.WriteLine("Ferrari...");
            Ferari c2 = new Ferari();
            Console.WriteLine(c2.Acelarar());
            Console.WriteLine(c2.Acelarar());
            Console.WriteLine(c2.Acelarar());
            Console.WriteLine(c2.Frear());
            Console.WriteLine(c2.Frear());

            // ocultado vai chamar o do                                                                  

            Console.WriteLine("Ferrari tipo carro");
            Carro c3 = new Ferari(); // polimorfismo
            Console.WriteLine(c3.Acelarar());
            Console.WriteLine(c3.Acelarar());
            Console.WriteLine(c3.Frear());
            Console.WriteLine(c3.Frear());
            Console.WriteLine(c3.Frear());

            Console.WriteLine("Polimorfimo trocando para uno no tipo carro");
            c3 = new Uno();
            Console.WriteLine(c3.Acelarar());
            Console.WriteLine(c3.Acelarar());
            Console.WriteLine(c3.Frear());
            Console.WriteLine(c3.Frear());
            Console.WriteLine(c3.Frear());


        }
    }
}

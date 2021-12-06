using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {

    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }
        public void Sacar(double valor) {
            if(valor > Saldo) {
                // exceção
                throw new ArgumentException("Saldo Insuficiente");
            };
            Saldo -= valor;
        }
    }
    internal class ExceErro {
        public static void Exe() {
            var conta = new Conta(150);
            

            try {
                int.Parse("abc");
                conta.Sacar(1000);
                Console.WriteLine("Retirada com sucesso!");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            } finally {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}

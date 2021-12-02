using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {
    internal class Construtor {
        
        class Carro {
            public string modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano) {
                // os construtor tem o mesmo nome, com somente o public, e 
                // this - referenciar o objeto do momento
                this.modelo = modelo;
                fabricante = Fabricante;
                ano = Ano;
            }
        }
        
        public static void Ex() {
            // logo dará erro para setar, já qie já tem o padrão,
            // que não recebe nehum parametro, ou seja,
            // não seta com algo que já existe
            // var carro1 = new Carro();
            // carro1.Fabricante = "BMW";
            //  carro1.modelo = "266i";
            // carro1.Ano = 1999;

        }
    }
}

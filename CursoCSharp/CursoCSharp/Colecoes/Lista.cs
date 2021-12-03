using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {


    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }
        public override bool Equals(object obj) {
            Produto outro = (Produto)obj;
            bool mesmoN = Nome == outro.Nome;
            bool mesmoP = Preco == outro.Preco;
            return mesmoN && mesmoP;
        }


        public override int GetHashCode() {
            // indíce do banco de dados - contam o tamanho (hashcode) e listar, (não deixando adicionar 1 do mesmos tamanho
            return Nome.Length;
        }

        public Produto() {

        }
    }
    internal class Lista {
        public static void exe() {
            var livro = new Produto();

            livro.Nome = "A menina que roubava livros";
            livro.Preco = 19.99;

            // List<tipodedado(no caso produto)>
            // a lista pode armazenar qualquer coisa - por isso genérica, especificamos o tipo somente
            var carrinho = new List<Produto>();
            // adicionar
            carrinho.Add(livro);
            // combo da lista - adicionando vários
            var combo = new List<Produto> {
                new Produto("Jogo Vozarez", 28.4),
                new Produto("Dark", 12.4),
                new Produto("Poster",45)
            };


            // adicionar o combo no carrinho
            carrinho.AddRange(combo);
            //Console.WriteLine(carrinho.Count);
            

            foreach (var liv in carrinho) {
                Console.WriteLine($"{liv.Nome} - {liv.Preco}");
            }

            Console.WriteLine("\n");
            carrinho.RemoveAt(3);

            foreach (var liv in carrinho) {
                Console.WriteLine($"{liv.Nome} - {liv.Preco}");
            }
            Console.WriteLine("\n");
        }
    }
}

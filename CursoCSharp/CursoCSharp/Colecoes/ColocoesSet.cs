using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColocoesSet {
        public static void exe() {
            var livro = new Produto();

            livro.Nome = "A menina que roubava livros";
            livro.Preco = 19.99;

            // List<tipodedado(no caso produto)>
            // a lista pode armazenar qualquer coisa - por isso genérica, especificamos o tipo somente
            //não é indexada, nada a ver com index, sem repetição
            var carrinho = new HashSet<Produto>();
            // adicionar
            carrinho.Add(livro);
            // combo da lista - adicionando vários
            var combo = new List<Produto> {
                new Produto("Jogo Vozarez", 28.4),
                new Produto("Dark", 12.4),
                new Produto("Poster",45)
            };


            // adicionar o combo no carrinho
            //carrinho.AddRange(combo);
            carrinho.UnionWith(combo);
            //Console.WriteLine(carrinho.Count);


            foreach (var liv in carrinho) {
                Console.WriteLine($"{liv.Nome} - {liv.Preco}");
            }

            Console.WriteLine("\n");
            //carrinho.RemoveAt(3);

            foreach (var liv in carrinho) {
                Console.WriteLine($"{liv.Nome} - {liv.Preco}");
            }
            Console.WriteLine("\n");
        }
    }
}

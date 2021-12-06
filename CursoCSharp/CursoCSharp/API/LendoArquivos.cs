using System;
using System.IO;

namespace CursoCSharp.API {
    internal class LendoArquivos {
        public static void Exe() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneca Bic;1.5;98");
                    sw.WriteLine("Borracha;4.4;51");
                }
            }

            try {
                using (StreamReader rd = new StreamReader(path)) {
                    var texto = rd.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

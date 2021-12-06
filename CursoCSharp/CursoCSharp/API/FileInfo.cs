using System;
using System.IO;

namespace CursoCSharp.API {
    internal class FileInfo {
        public static void Exe() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo fi = new FileInfo();


        }
    }
}

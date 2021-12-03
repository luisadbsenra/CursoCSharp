using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
        // interface é um classe que a função sem corpo
        interface Ponto {
            // pública
            void MoverDiag(int del);
        }
        // struct aderente a interface ponto
        struct Coordenada : Ponto {
            public int X;
            public int Y;
            
            public Coordenada(int x, int y) {
                X = x;
                Y = y;
            }

            public void MoverDiag(int delta) {
                X += delta;
                Y += delta;
            }
        }
        
    

    class ExemploStruct{
        public static void Execu() {
            Coordenada coordenada;
            coordenada.X = 2;
            coordenada.Y = 2;

            Console.WriteLine("Coordenada Inicial\n" +
                $"X = {coordenada.X}, Y = {coordenada.Y}");

            var cf = new Coordenada();
            cf.X = 9;
            cf.Y = 1;
            cf.MoverDiag(10);
            Console.WriteLine(cf.X);
            Console.WriteLine(cf.Y);
            


        }
    }
}

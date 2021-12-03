using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classe {

    public class Moto {
        // não fica visível, encapsulado, visível apenas na classe 
        // só acessa por meio de um método
        private string Marca;
        private string Modelo;
        private uint Cilindro;

        // construtor
        public Moto(string marca, string modelo, uint cilindro) {
            //Marca = marca;
            //Modelo = modelo;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindro(cilindro);
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }


        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }


        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindro() {

            return Cilindro;
        }


        public void SetCilindro(uint cilindro) {
            //if (cilindro < 0) {
            //Cilindro = cilindro;
            //}

            // módulo
            //Cilindro = Math.Abs(cilindro);

            Cilindro = cilindro;


        }

    }

    internal class GetSet {
        public static void ex() {
            var m1 = new Moto("Kawaskim", "Ninja ZX-6R", 636);

            Console.WriteLine(m1.GetMarca());
            Console.WriteLine(m1.GetModelo());
            Console.WriteLine(m1.GetCilindro());

            var m2 = new Moto();
            m2.SetCilindro(150);
            m2.SetMarca("Honda");
            m2.SetModelo("G6-54");

            Console.WriteLine($"\n{m2.GetModelo()} {m2.GetMarca()} {m2.GetCilindro()}");
        }
    }
}

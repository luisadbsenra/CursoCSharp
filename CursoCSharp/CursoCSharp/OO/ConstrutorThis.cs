﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} incializado");
        }

        // chamar o construtor da própias classe pra setar o nome
        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    internal class ConstrutorThis {
        public static void Exe() {
            var spike = new Cachorro("Spike", 50);
            var max = new Cachorro("Max", 40);

            Console.WriteLine(spike);
            Console.WriteLine(max);

        }

        
        
    }
}

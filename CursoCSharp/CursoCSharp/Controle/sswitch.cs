using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class sswitch {
        public static void ex(){
            Console.WriteLine("Atendimento de 1 a 5:");
            int.TryParse(Console.ReadLine(), out int n);

            switch (n){
                case 1:
                    Console.WriteLine("baad");
                    break;
                case 2:
                    Console.WriteLine("ruim");
                    break; 
                case 3:
                    Console.WriteLine("inter");
                    break; 
                case 4:
                    Console.WriteLine("bom");
                    break; 
                case 5:
                    Console.WriteLine("cool");
                    break;
                default:
                    Console.WriteLine("Sem nota");
                    break;
            }
        }

    }
}

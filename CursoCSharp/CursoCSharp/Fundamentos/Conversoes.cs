using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class Conversoes {
        public static void Make() {

            // no problems
            int i = 10;
            double q;
            q = i;
            Console.WriteLine(q);


            double nota = 9.44;
            int not;
            // conversão forçada
            not = (int) nota;
            Console.WriteLine( "Nota Truncada (0)", not);

            // converter com outra variavel
            Console.WriteLine("Idade:");
            string idadeS = Console.ReadLine();
            int idadeI = int.Parse(idadeS);
            Console.WriteLine("Idade inserida: {0}", idadeI);

            // convert diferente
            idadeI = Convert.ToInt32(idadeS);
            Console.WriteLine("Result: {0}", idadeI);

            // in e out
            Console.WriteLine("1°");
            string palavra = Console.ReadLine();
            int n;
            //converta palavra e tranforme em um número
            int.TryParse(palavra, out n);
            Console.WriteLine("Resultado: {0}", n); 
            
            
            // in e out 2
            Console.WriteLine("2°");
            //converta palavra e tranforme em um número
            int.TryParse(Console.ReadLine(), out int n2);
            Console.WriteLine("Resultado: {0}", n2);
        }
    }
}

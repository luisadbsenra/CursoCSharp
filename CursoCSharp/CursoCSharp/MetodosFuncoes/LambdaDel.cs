using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosFuncoes {

   // delegate double Oper(double x, double y);

    internal class LambdaDel {
        // varios tipos 

        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void exee() {
            //Oper sum = (x, y) => x + y;
            //Oper sub = (x, y) => x - y;
            //Oper mul = (x, y) => x * y;


            //Console.WriteLine(sum(4, 9));
            //Console.WriteLine(sub(4, 9));
            //Console.WriteLine(mul(4, 9));

            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 4.5));

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2,3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(8, 4);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.MetodosEFuncoes {

    delegate double Operacao(double x, double y);

    class LambdasDelegate {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao multi = (x, y) => x * y;

            Console.WriteLine(sum(2, 8));
            Console.WriteLine(sub(10, 5));
            Console.WriteLine(multi (6, 7));

        }
    }
}

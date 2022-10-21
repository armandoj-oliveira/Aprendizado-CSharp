using System;

namespace CSharp.MetodosEFuncoes {
    class UsandoDelegate {

        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }

        static void MeuImprimirSoma(double x, double y) {
            Console.WriteLine(x + y);
        }

        public static void Executar() {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5, 8);
        }
    }
}

using System;

namespace CSharp.MetodosEFuncoes {

    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero;
        }

        public static double Subtracao(this double num, double outroNumero) {
            return num + outroNumero;
        }

        
    }

    class MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;
            double numReal = 5.5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numReal.Subtracao(2));

            Console.WriteLine(2.Soma(5));
            Console.WriteLine(2.9.Subtracao(4.9));

        }
    }
}

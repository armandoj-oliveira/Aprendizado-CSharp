using System;
using System.Globalization;

namespace CSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Valor com uma casa Decimal
            Console.WriteLine(valor.ToString("C")); // Moeda
            Console.WriteLine(valor.ToString("P")); // Percentual
            Console.WriteLine(valor.ToString("#.##")); // Valor com duas casa Decimais

            CultureInfo cultura = new CultureInfo("en-US"); // Formatação específica
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}

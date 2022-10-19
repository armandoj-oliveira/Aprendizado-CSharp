using System;

namespace CSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto}");

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Potência
            Console.WriteLine($"O IMC é: {imc}");

            // Número Par
            int par = 24;
            int impar = 55;
            Console.WriteLine($"O número {par}/2 tem o resto valendo: {par % 2}");
            Console.WriteLine($"O número {impar}/2 tem o resto valendo: {impar % 2}");

        }
    }
}

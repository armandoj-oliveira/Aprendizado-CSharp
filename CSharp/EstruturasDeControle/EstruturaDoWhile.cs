using System;


namespace CSharp.EstruturasDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string entrada;

            do {
                Console.Write("Qual o seu nome? ");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem-vindo {entrada}");
                Console.Write($"Deseja continuar? (S/N) ");
            } while (entrada.ToLower() == "s");

        }
    }
}

using System;

namespace CSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;               
            double quebrado = inteiro;  // Conversão Implícita
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota; // Conversão Explícita - Possibilidade de Perda de Informação
            Console.WriteLine($"Nota Truncada: {notaTruncada}");

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            // Forma mais segura
            Console.Write("Digite um número: ");
            string palavra = Console.ReadLine();
            // int numero;
            int.TryParse(palavra, out int numero);
            Console.WriteLine($"Resultado {numero}");

            //Outra Forma
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"O Resultado do número 2 é: {numero2}");

        }
    }
}

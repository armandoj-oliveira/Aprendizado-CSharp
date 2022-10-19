using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raioCircunferencia = 4.5;
            const double PI = 3.14; // Não muda seu valor

            double areaCirfunerencia = PI * raioCircunferencia * raioCircunferencia;
            Console.WriteLine($"A área da circunferência é: {areaCirfunerencia}");

            // Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine($"Está chovendo? {estaChovendo}");

            byte idade = 45;
            Console.WriteLine($"Idade: {idade} anos");

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine($"O saldo de Gols é: {saldoDeGols}");

            sbyte salario = sbyte.MaxValue;
            Console.WriteLine($"O salário é: {salario}");

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine($"Menor int é: {menorValorInt}");

            uint populacaoBrasileira = 207_600_000; // Sempre valor positivo
            Console.WriteLine($"A População Brasileira é de: {populacaoBrasileira} habitantes.");

            long menorValorLong = long.MinValue;
            Console.WriteLine($"Menor long é: {menorValorLong}");

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine($"A População Mundial é de: {populacaoMundial} habitantes.");

            float precoComputador = 1299.99f; // Todas as variaveis com casa decimais são do tipo double, por isso se usa f no final para determinar seu tipo
            Console.WriteLine($"O preço do Computador é: {precoComputador}");

            double valorDeMercadoApple = 1_000_000_000_000.00; // Mais usado dos Reais
            Console.WriteLine($"O valor da Appel é; {valorDeMercadoApple}");

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine($"A distância é: {distanciaEntreEstrelas}");

            char letra = 'I';
            Console.WriteLine(letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}

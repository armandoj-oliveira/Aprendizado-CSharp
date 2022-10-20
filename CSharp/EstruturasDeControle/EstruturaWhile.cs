﻿using System;

namespace CSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestantes = 5;
            int tentativas = 0;

            while (tentativaRestantes > 0 && !numeroEncontrado) {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write($"Número encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAnterior;
                } else if (numeroSecreto < palpite) {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine($"Tentativas Restantes: {tentativaRestantes}");
                } else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine($"Tentativas Restantes: {tentativaRestantes}");
                }
            }
        }
    }
}

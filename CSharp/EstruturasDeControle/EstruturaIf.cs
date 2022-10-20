﻿using System;

namespace CSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento? (S/N) ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s") 
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s";

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de Honra!");
            }
        }
    }
} 

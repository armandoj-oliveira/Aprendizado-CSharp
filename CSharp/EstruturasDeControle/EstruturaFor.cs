using System;

namespace CSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
            //for (int i; i <= 10, i++) {
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Inforne o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write($"Informe a nota do aluno {i}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAluno);

                somatorio += notaAluno;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma: 0;
            Console.WriteLine($"Média da Turma: {media}");
        }
    }
}

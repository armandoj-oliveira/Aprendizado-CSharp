using System;

namespace CSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double notaAluno);

            if (notaAluno >= 9.0) {
                Console.WriteLine("Quadro de Honra!");
            } else if (notaAluno >= 7.0) {
                Console.WriteLine("Aprovado!");
            } else if (notaAluno >= 5.0){
                Console.WriteLine("Recuperação!");
            } else {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}

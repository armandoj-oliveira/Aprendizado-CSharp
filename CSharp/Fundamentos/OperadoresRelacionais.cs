using System;

namespace CSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {

            Console.Write("Digite a nota do aluno: ");
            // double nota = 6.0;
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota Inválida? {nota > 10.0}");
            Console.WriteLine($"Nota Inválida? {nota < 0.0}");
            Console.WriteLine($"Perfeito? {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar? {nota != 0.0}");
            Console.WriteLine($"Passou por Média? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota <= 3.0}");

        }
    }
}

using System;
using System.Globalization;


namespace CSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Serve para colocar o . como separador de casas decimais

            Console.WriteLine($"Olá {nome}, você tem {idade} anos e ganha R${salario}");
        }
    }
}

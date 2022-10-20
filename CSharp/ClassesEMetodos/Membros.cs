using System;


namespace CSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Isabella";
            pessoa.Idade = 18;

            pessoa.ApresentarNoConsole();
            pessoa.Zerar();
            pessoa.ApresentarNoConsole();

            var novaPessoa = new Pessoa();
            novaPessoa.Nome = "Armando";
            novaPessoa.Idade = 19;

            var apresentacaoDaNovaPessoa = novaPessoa.Apresentar();
            Console.WriteLine(apresentacaoDaNovaPessoa);


        }
    }
}

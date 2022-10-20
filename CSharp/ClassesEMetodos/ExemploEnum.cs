using System;

namespace CSharp.ClassesEMetodos {

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParafamilia = new Filme();
            filmeParafamilia.Titulo = "Sharknard 17";
            filmeParafamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine($"{filmeParafamilia.Titulo} é {filmeParafamilia.GeneroDoFilme}!");
        }
    }
}

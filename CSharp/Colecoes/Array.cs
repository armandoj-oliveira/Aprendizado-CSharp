using System;

namespace CSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Armando";
            alunos[1] = "Isabella";
            alunos[2] = "Miguel";
            alunos[3] = "Isla";
            alunos[4] = "Nando";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            //for(int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavras = new string(letras);
            Console.WriteLine(palavras);
        }
    }
}

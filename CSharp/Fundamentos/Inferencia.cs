using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Isabella"; // o C# reconhece o tipo da variável
            Console.WriteLine(nome);

            // int idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 2;
            int b = 3;
            Console.WriteLine(a + b);
        }
    }
}

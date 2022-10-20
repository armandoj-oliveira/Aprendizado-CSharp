using System;

namespace CSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado); 
            
            var nota2 = 6.0;
            string resultado2 = nota2 >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado2);

            bool bomComportamento = true;
            string resultadoComportamento = nota>= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultadoComportamento);

        }
    }
}

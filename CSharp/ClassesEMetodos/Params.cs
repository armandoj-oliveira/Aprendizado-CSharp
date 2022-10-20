using System;


namespace CSharp.ClassesEMetodos {
    class Params {

        public static void Recepcinoar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");
            }
        }

        public static void Executar() {
            Recepcinoar("Armando", "Isabella", "Isla", "Miguel");
        }
    }
}

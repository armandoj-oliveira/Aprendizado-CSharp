using System;

namespace CSharp.EstruturasDeControle {
    class UsandoBreak {
        public static void Executar() {
            Random r = new Random();
            int numero = r.Next(1, 51);

            Console.WriteLine($"O número que queremos é: {numero}");

            for (int i = 1; i <= 50; i++) {
                Console.Write($"{i} é o número que queremos? ");
                if (i == numero) {
                    Console.WriteLine("Sim");
                    break;
                } else {
                    Console.WriteLine("Não");
                }
            }

            Console.WriteLine("FIM!");

        }
    }
}

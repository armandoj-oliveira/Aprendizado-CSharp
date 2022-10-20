namespace CSharp.EstruturasDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.Write("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int avaliacao);

            switch (avaliacao) {
                case 1:
                    Console.WriteLine("Péssimo");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("Nota Inválida");
                    break;
            }

            Console.WriteLine("Obrigao por responder!");
        }
    }
}

using System;


namespace CSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVSClasses {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1; // Atribução por Valor
            ponto1.X = 3;

            Console.WriteLine($"Ponto 1 X: {ponto1.X}");
            Console.WriteLine($"Copia Ponto 1 X: {copiaPonto1.X}");

            CPonto ponto2 = new CPonto { X = 2, Y = 4};
            CPonto copiaPonto2 = ponto2; // Atribuição por Referência
            ponto2.X = 4;

            Console.WriteLine($"Ponto 1 X: {ponto2.X}");
            Console.WriteLine($"Copia Ponto 1 X: {copiaPonto2.X}");
        }
    }
}

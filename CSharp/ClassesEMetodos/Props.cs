using System;

namespace CSharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1;
        string nome;

        public string Nome {
            get { return "Opcional: " + nome; }
            set { nome = value; }
        }

        // Propriedades autoimplementadas
        public double Preco { get; set; }

        // Somente Leitura
        public double PrecoDesconto {
            get => Preco - (desconto * Preco);
            set { desconto = value; }
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }

    class Props {
        public static void Executar() {
            var opc1 = new CarroOpcional("Ar Condicionado", 3499.90);
            Console.WriteLine(opc1.PrecoDesconto);

            var opc2 = new CarroOpcional();
            opc2.Nome = "Direação Elétrica";
            opc2.Preco = 2349.90;

            Console.WriteLine(opc1.Nome);
            Console.WriteLine(opc1.Preco);

            Console.WriteLine(opc2.Nome);
            Console.WriteLine(opc2.Preco);
        }
    }
}

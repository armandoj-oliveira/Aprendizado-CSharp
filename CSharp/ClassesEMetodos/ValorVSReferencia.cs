using System;


namespace CSharp.ClassesEMetodos {

    public class Dependente {
        public string Nome;
        public int Idade;
    }
    class ValorVSReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero}, {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero}, {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome}, {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade}, {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            copiaDep.Idade = 21;

            Console.WriteLine($"{copiaDep.Nome}, {copiaDep.Idade}");
        }
    }
}

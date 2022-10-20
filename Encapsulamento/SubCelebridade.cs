namespace Encapsulamento {
    public class SubCelebridade {
        // Todos
        public string InfoPublica = "Tenho um Instagram!";

        // Herança
        protected string CorDosOlhos = "Verde";

        // Mesmo Projeto
        internal ulong NumeroCelular = 551199999999;

        // Herança ou Mesmo Projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Mesa Class ou Herança no Mesmo Projeto
        private protected string SegredoFamilia = "Bla Bla";

        // Private é Padrão
        bool UsoMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsoMuitoPhotoshop);
        }
    }
}
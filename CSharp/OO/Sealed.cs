using System;
namespace CSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 2_000_000.32;
        }
    }

    class Avo {
        public virtual bool HonraNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonraNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        // public override bool HonrarNomeFamilia()
    }

    class Sealed {
        public static void Executar() {

        }
    }
}

namespace Esercizio_U4_S1_L3.Models {
    public class ContoCorrente {

        public string NomeConto {
            get; set;
        } = "";

        public decimal SaldoConto {
            get; set;
        } = 0;

        public bool ContoAperto {
            get; set;
        } = false;

        public ContoCorrente(string nomeConto, decimal saldoConto) {
            NomeConto = nomeConto;
            if (saldoConto < 1000) {
                Console.WriteLine("Il saldo iniziale del conto non può essere inferiore a 1000 euro.");
            } else {
                SaldoConto += saldoConto;
                ContoAperto = true;
            }

        }

        public void ToggleConto() {
            ContoAperto = !ContoAperto;
        }

        public void Versa(decimal n) {
            if (ContoAperto) {
                SaldoConto += n;
            } else {
                Console.WriteLine("Il conto è chiuso.");
            }
        }

        public void Preleva(decimal n) {
            if (ContoAperto && SaldoConto >= n) {
                SaldoConto -= n;
            } else {
                Console.WriteLine("Il conto è chiuso oppure non hai abbastanza soldi nel conto per prelevare tale quantità.");
            }
        }
    }
}

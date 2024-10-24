using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiements
{
    public class PayPal: Paiement
    {
        public string Courriel { get; set; }
        public PayPal(double montant, string description, string courriel)
        : base(montant, description)
        {
            Courriel = courriel;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Montant: {Montant}, Description: {Description}, Courriel: {Courriel}");
        }
    }
}

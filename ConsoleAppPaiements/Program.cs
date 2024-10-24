using ConsoleAppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit achat1 = new CarteCredit(29.99, "Achat de vetements sur ASOS", 987654321);
        CarteCredit achat2 = new CarteCredit(1199.99, "Achat d'un ordinateur sur Lenovo", 987654321);
        CarteCredit achat3 = new CarteCredit(250.00, "Achat d'un nouvel appareil électronique sur Amazone", 987654530);

        PayPal payment1 = new PayPal(59.99, "Achat en ligne", "300130566@monboreal.ca");
        PayPal payment2 = new PayPal(19.99, "Abonnement mensuel", "300130566@monboreal.ca");

        achat1.AfficherDetails();
        achat2.AfficherDetails();
        achat3.AfficherDetails();

        payment1.AfficherDetails();
        payment2.AfficherDetails();

        Utilisateur user = new Utilisateur("Chefik Sadissou");
        user.AjouterPaiement(achat1);
        user.AjouterPaiement(achat2);
        user.AjouterPaiement(achat3);
        user.AjouterPaiement(payment1);
        user.AjouterPaiement(payment2);

        user.AfficherInfos(); 
    }
}
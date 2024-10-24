using ConsoleAppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit achat1 = new CarteCredit(29.99, "Achat de vetements sur ASOS", 987654321);
        CarteCredit achat2 = new CarteCredit(99.99, "Achat d'un ordinateur sur Lenovo", 987654321);
        CarteCredit achat3 = new CarteCredit(250.00, "Achat d'un nouvel appareil électronique sur Amazone", 987654530);

        achat1.AfficherDetails();
        achat2.AfficherDetails();
        achat3.AfficherDetails();
    }
}
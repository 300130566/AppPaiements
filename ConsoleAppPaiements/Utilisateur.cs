﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiements
{
<<<<<<< HEAD
    public class Utilisateur
=======
   public class Utilisateur
>>>>>>> origin/main
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Nom: {Nom}");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
<<<<<<< HEAD
=======
            
>>>>>>> origin/main
        }

        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
    }
}

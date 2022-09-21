using System;
using System.Collections;
using System.Collections.Generic;
using pendu;
namespace pendu
{
    class affichages
    {

        public void affichage()
        {

            Console.WriteLine("ceci est un test d'affichage");
            Console.WriteLine("**************************\n****** Bienvenue dans LA PANDAISON ******\n**************************");

        }
        public void ShowErreurs(int Erreurs)
        {
            string PenduErreur = pendu[Erreurs];
            Console.WriteLine("CECI EST UN TEST DE ERREUR TU SAIT" + PenduErreur);
            return;

        }
        public void ShowLetters()
        {//prendre les lettres fausse et afficher toute la liste (LettresFausses dans logique.cs)
        }

        string[] pendu = new string[] { "premier stage", "deuxieme stage", "troisieme stage", "quatrieme stage", "cinquieme stage", "sixieme stage", "septieme stage", "huitieme stage", "neuvieme stage", "DERNIER stage" };

    }
}

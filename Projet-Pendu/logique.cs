using System;
using System.Collections;
using System.Collections.Generic;

namespace logique
{

    class logique
    {
        public int TailleMot;
        public string MotRandom;
        public int NmbrLettresUtilise = 0;
        public string InputUtilisateur;

        public void logique()
        {
            //prendre un mot random
            console.WriteLine("ceci est un test de logique");
            //ici on definis la taille du mot qu'on utlise
            TailleMot = mots.GetLength;
            console.WriteLine("la taille du mot est" + TailleMot);

            if (IsAlphabetic) console.WriteLine("Veulliez entrer uniquement des lettres");
            else
            {
                //mettre ici le reste de la logique
                //demander input utilisateur et comparer les lettres aux lettres du mot
                //si faux ajouter 1 a NmbreLettresUtilise (si arrive a 10 = perdu) si vrai montrer la lettre
                //faire en sorte de ne pas pouvoir jouer une lettre qui a dejé été utilisée (surement via un tableau)

            }


        }
        public bool IsAlphabetic(string InputUtilisateur)
        {
            bool result = int.TryParse(InputUtilisateur);
            return result;
        }
        string[] alphabet = new string[]("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z");
        //au cas ou on oublie l'alphabet (lol)
        string[] mots = new string[]("voiture", "camion", "pizza", "ordinateur", "amnesique", "renard", "arbuste", "armure", "espadrille", "jonquille", "graduation", "justice", "cabinet", "karaoke", "question", "vitre", "platane", "lombaire", "canette", "jardinerie", "esperance", "caractere", "anguille", "niveau");
        //le tableau contient 24 mots

    }
}
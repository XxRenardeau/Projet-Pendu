using System;
using System.Collections;
using System.Collections.Generic;
using pendu;

namespace pendu
{

    public class logique
    {
        public int TailleMot = 0;
        public string MotRandom = "";
        public int NmbrLettresUtilise = 0;
        public char InputUtilisateur = ' ';
        public bool win = false;
        public Mots currentMot;

        public void MainLogique()
        {
            MotRandom = RandomMot();
            currentMot = new Mots(MotRandom);
            //prendre un mot random
            Console.WriteLine("ceci est un test de logique");
            //ici on definis la taille du mot qu'on utlise
            TailleMot = MotRandom.Length;
            Console.WriteLine("la taille du mot est " + TailleMot);
            Console.WriteLine("le mot est " + MotRandom);
            Console.WriteLine("veulliez entrer une lettre");

            while (!win)
            {
                InputUtilisateur = char.ToUpper(Console.ReadKey(true).KeyChar);
                Console.WriteLine(InputUtilisateur);
                if (!IsAlphabetic(InputUtilisateur)) Console.WriteLine("Veulliez entrer uniquement des lettres");
                else
                {
                    Console.WriteLine(currentMot.Contient(InputUtilisateur));
                    if (currentMot.Contient(InputUtilisateur))
                    {
                        LettresDevinees.Add(InputUtilisateur);
                        Console.WriteLine("vous avez deviné " + LettresDevinees.Count + (" lettres différentes"));




                    }
                    else
                    {return;
                    }

                    //mettre ici le reste de la logique
                    //demander input utilisateur et comparer les lettres aux lettres du mot
                    //si faux ajouter 1 a NmbreLettresUtilise (si arrive a 10 = perdu) si vrai montrer la lettre
                    //faire en sorte de ne pas pouvoir jouer une lettre qui a dejé été utilisée (surement via un tableau)

                }
            }


        }
        public bool IsAlphabetic(char InputUtilisateur)
        {
            return char.IsLetter(InputUtilisateur);

        }

        public string RandomMot()
        {
            Random Rnd = new Random();
            int RndIndex = Rnd.Next(0, mots.Length - 1);
            string mot = mots[RndIndex];
            return mot;

        }
        List<char> LettresDevinees = new List<char>();
        string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        //au cas ou on oublie l'alphabet (lol)
        string[] mots = new string[] { "voiture", "camion", "pizza", "ordinateur", "amnesique", "renard", "arbuste", "armure", "espadrille", "jonquille", "graduation", "justice", "cabinet", "karaoke", "question", "vitre", "platane", "lombaire", "canette", "jardinerie", "esperance", "caractere", "anguille", "niveau" };
        //le tableau contient 24 mots

    }
}
public class Mots
{
    string mot;
    public Mots(string mot)
    {
        this.mot = mot;
        this.mot = this.mot.ToUpper();
    }

    public int NmbreLettresMot()
    {
        return mot.Length;
    }
    public bool Contient(char Lettre)
    {
        return mot.Contains(Lettre);
    }



}
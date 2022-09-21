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
        public int Erreurs = -1;
        public int ErreursMax = 9;
        public int zero = 0;
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
            LettresDansMot.AddRange(MotRandom.ToUpper());
            int LettresDansMotNombreValue = LettresDansMot.Count();
            Console.WriteLine(String.Join(", ", LettresDansMot));
            while (!win)
            {//;

                InputUtilisateur = char.ToUpper(Console.ReadKey(true).KeyChar);
                Console.WriteLine(InputUtilisateur);
                if (!IsAlphabetic(InputUtilisateur)) Console.WriteLine("Veulliez entrer uniquement des lettres");
                else
                {


                    Console.WriteLine(currentMot.Contient(InputUtilisateur));
                    if (AllInput.Contains(InputUtilisateur))
                    {
                        Console.WriteLine("VEULLIEZ ENTRER DES LETTRES QUE VOUS NAVEZ PAS DEJA DEVINE");
                    }
                    else if (currentMot.Contient(InputUtilisateur))
                    {
                        LettresDevinees.Add(InputUtilisateur);
                        AllInput.Add(InputUtilisateur);
                        Console.WriteLine("");
                        //Console.WriteLine("vous avez deviné " + LettresDevinees.Count + (" lettres différentes"));
                        while (LettresDansMot.Contains(InputUtilisateur)) { LettresDansMot.Remove(InputUtilisateur); }
                        Console.WriteLine(String.Join(", ", LettresDansMot));
                        if (LettresDansMot.Count() == zero)
                        {
                            win = true;
                            Console.WriteLine("bien joué");

                        }
                        else
                        {

                        }
                    }

                    else
                    {
                        LettresFausses.Add(InputUtilisateur);
                        AllInput.Add(InputUtilisateur);
                        Erreurs++;
                        if (ErreursMax - Erreurs == zero)
                        {
                            Console.WriteLine("t mor lol");
                            return;

                        }
                        else
                        {

                            //currentAffichage.ShowErreurs(Erreurs);
                            Console.WriteLine("vous avez fait " + Erreurs + (" erreurs"));
                        }

                    }

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
        List<char> LettresDansMot = new List<char>();
        List<char> LettresDevinees = new List<char>();
        List<char> LettresFausses = new List<char>();
        List<char> AllInput = new List<char>();
        string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        //au cas ou on oublie l'alphabet (lol)
        string[] mots = new string[] { "voiture", "camion", "pizza", "ordinateur", "amnesique", "renard", "arbuste", "armure", "espadrille", "jonquille", "graduation", "justice", "cabinet", "karaoke", "question", "vitre", "platane", "lombaire", "canette", "jardinerie", "esperance", "caractere", "anguille", "niveau" };
        //le tableau contient 24 mots

    }
}
public class Mots
{
    string mot;
    char LtrsDansMot;
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
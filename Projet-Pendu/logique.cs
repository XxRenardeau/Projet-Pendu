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
        public int Erreurs = 0;
        public int ErreurMax = 10;
        public int zero = 0;
        public Mots currentMot;
        public affichages currentAffichage;
        public void MainLogique()
        {
            currentAffichage = new affichages(this);
            //currentAffichage.affichage();
            MotRandom = RandomMot();
            currentMot = new Mots(MotRandom);
            //prendre un mot random
            //Console.WriteLine("ceci est un test de logique");
            //ici on definis la taille du mot qu'on utlise
            TailleMot = MotRandom.Length;
            /*Console.WriteLine("la taille du mot est " + TailleMot);
            Console.WriteLine("le mot est " + MotRandom);*/
            currentAffichage.GameUI();
            Console.WriteLine("veulliez entrer une lettre");
            LettresDansMot.AddRange(MotRandom.ToUpper());
            Console.WriteLine(String.Join(", ", LettresDansMot));
            while (!win)
            {

                currentAffichage.GameUI();
                InputUtilisateur = char.ToUpper(Console.ReadKey(true).KeyChar);
                Console.WriteLine(InputUtilisateur);
                currentAffichage.GameUI();
                if (!IsAlphabetic(InputUtilisateur)) Console.WriteLine("Veulliez entrer uniquement des lettres");
                else
                {
                    //Console.WriteLine(currentMot.Contient(InputUtilisateur));
                    if (AllInput.Contains(InputUtilisateur))
                    {
                        currentAffichage.GameUI();
                        Console.WriteLine("VEULLIEZ ENTRER DES LETTRES QUE VOUS NAVEZ PAS DEJA DEVINE");
                    }
                    else if (currentMot.Contient(InputUtilisateur))
                    {
                        LettresDevinees.Add(InputUtilisateur);
                        AllInput.Add(InputUtilisateur);
                        //Console.WriteLine("vous avez deviné " + LettresDevinees.Count + (" lettres différentes"));
                        while (LettresDansMot.Contains(InputUtilisateur)) { LettresDansMot.Remove(InputUtilisateur); }
                        Console.WriteLine(String.Join(", ", LettresDansMot));
                        if (LettresDansMot.Count() == zero)
                        {
                            currentAffichage.GameUI();
                            win = true;
                            Console.WriteLine("bien joué");
                            break;
                            //demander si le joeur veut rejouer

                        }
                    }

                    else
                    {
                        LettresFausses.Add(InputUtilisateur);
                        AllInput.Add(InputUtilisateur);
                        Erreurs++;
                        currentAffichage.GameUI();
                        if (ErreurMax - Erreurs == zero)
                        {
                            Console.WriteLine("t mor lol");
                            return;

                        }
                        else
                        {

                            //currentAffichage.Show();
                            //Console.WriteLine("vous avez fait " +  + (" "));
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
        public List<char> LettresDevinees = new List<char>();
        List<char> LettresFausses = new List<char>();
        public List<char> AllInput = new List<char>();
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
    public char LettreIndex(int index)
    {
        return mot[index];

    }

}
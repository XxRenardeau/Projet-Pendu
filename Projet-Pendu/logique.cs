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
            StartResart();
            Erreurs = 0;

            currentAffichage.GameUI();
            while (!win)
            {


                currentAffichage.GameUI();
                InputUtilisateur = char.ToUpper(Console.ReadKey(true).KeyChar); //demande l'input utilisateur en format char et le convertis en majuscule
                Console.WriteLine(InputUtilisateur);
                currentAffichage.GameUI();
                if (!IsAlphabetic(InputUtilisateur)) currentAffichage.NotAlphabetic(); //verifie si la saisie est alphabetique et si elle ne l'est pas , met un message d'erreur
                else
                {
                    if (AllInput.Contains(InputUtilisateur))
                    {
                        currentAffichage.AlreadyGuessed(); //verifie si la saisie n'as pas déja été soumise , si elle l'as été , met un message d'erreur
                    }
                    else if (currentMot.Contient(InputUtilisateur))
                    {
                        LettresDevinees.Add(InputUtilisateur);
                        AllInput.Add(InputUtilisateur);
                        while (LettresDansMot.Contains(InputUtilisateur)) { LettresDansMot.Remove(InputUtilisateur); } //boucle qui boucle jusqua que toutes les lettres devinée dans le mot soient enlevée des lettres a deviner
                        Console.WriteLine(String.Join(", ", LettresDansMot));
                        if (LettresDansMot.Count() == zero)
                        {
                            //reinitiallise l'affichage , casse la boucle de jeu et demande a l'utilisateur si il veut rejouer
                            currentAffichage.GameUI();
                            win = true;
                            currentAffichage.GG();
                            Reset();
                            ResartChoice();
                            return;


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
                            //reinitiallise l'affichage , casse la boucle de jeu et demande a l'utilisateur si il veut rejouer
                            currentAffichage.GameUI();
                            win = true;
                            Reset();
                            currentAffichage.GamePerdu();
                            ResartChoice();
                            return;



                        }

                    }

                }
            }


        }

        public bool IsAlphabetic(char InputUtilisateur)
        {
            //cette fonction regarde si l'input utilisateur est une lettre (créé une erreur si l'input n'est pas une lettre)
            return char.IsLetter(InputUtilisateur);

        }

        public string RandomMot()
        {
            //cette fonction décide du mot a utiliser pour la partie
            Random Rnd = new Random();
            int RndIndex = Rnd.Next(0, mots.Length - 1);
            string mot = mots[RndIndex];
            return mot;

        }
        List<char> LettresDansMot = new List<char>();
        //cette liste contient les lettres décomposée du mot a deviner
        public List<char> LettresDevinees = new List<char>();
        //cette liste conteitn toute les lettres bien devinées
        List<char> LettresFausses = new List<char>();
        //cette liste contient toutes les lettres mal devinées
        public List<char> AllInput = new List<char>();
        //cette liste contient tout les inputs qu'importe si ils sont vrai ou faux
        string[] mots = new string[] { "voiture", "camion", "pizza", "ordinateur", "amnesique", "renard", "arbuste", "armure", "espadrille", "jonquille", "graduation", "justice", "cabinet", "karaoke", "question", "vitre", "platane", "lombaire", "canette", "jardinerie", "esperance", "caractere", "anguille", "niveau" };
        //le tableau contient les mots qui sont dans le jeu , il contient 24 mots


        public void StartResart() //fonction dirigeant le début de partie et etant appelée a la premiere partie ou a chaque nouvelle partie
        {

            if (currentAffichage == null) currentAffichage = new affichages(this);
            Reset();
            currentAffichage = new affichages(this); //créé une nouvelle instance de affichage pour generer une nouvelle interface
            MotRandom = RandomMot();
            currentMot = new Mots(MotRandom); //définit un nouveau mot a etre utilisé dans la logique
            TailleMot = MotRandom.Length;
            currentAffichage.GameUI();
            LettresDansMot.AddRange(MotRandom.ToUpper());
            Console.WriteLine(String.Join(", ", LettresDansMot)); //prend les lettres du mot random et les met sous format char dans la liste 


        }
        public void Reset() //remet les listes a 0 et les erreurs a leur états de base
        {
            LettresDansMot.Clear();
            LettresDevinees.Clear();
            LettresFausses.Clear();
            AllInput.Clear();
            win = false;
            Erreurs = 0;
        }
        public void ResartChoice() //demande a l'utilisateur si il veut rejouer
        {
            while (true)
            {
                InputUtilisateur = char.ToUpper(Console.ReadKey(true).KeyChar);
                if (InputUtilisateur == 'Y')
                {
                    StartResart();
                    break;
                }
                else if (InputUtilisateur == 'N')
                {
                    currentAffichage.Bye(); //bug qui empeche de fermer le jeu
                    break;
                }

            }
        }

    }
}
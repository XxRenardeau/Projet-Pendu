using System;
using System.Collections;
using System.Collections.Generic;
using pendu;
namespace pendu
{
    public class affichages
    {
        public logique LogiqueUI;


        public affichages(logique logique)
        {
            LogiqueUI = logique;
        }
        public void ShowErreurs()
        {
            string PenduErreur = pendu[LogiqueUI.Erreurs];
            Console.WriteLine(PenduErreur);
            return;

        }
        public void ShowLetters()
        {
            string Traits = string.Empty;
            for (int i = 0; i < LogiqueUI.TailleMot; i++)
            {
                char CurrentLettre = LogiqueUI.currentMot.LettreIndex(i);
                if (LogiqueUI.LettresDevinees.Contains(CurrentLettre))
                {
                    Traits += CurrentLettre;

                }
                else
                {
                    Traits += "_ ";
                }
            }
            Console.WriteLine("\n" + Traits);
        }
        public void LettresJouees()
        {
            string LettresJouees = string.Empty;
            for (int i = 0; i < LogiqueUI.AllInput.Count; i++)
            {
                LettresJouees += LogiqueUI.AllInput[i] + ",";
            }
            Console.WriteLine("\n \n" + LettresJouees);

        }
        public void GameUI()
        {
            Console.Clear();
            Titre();
            ShowLetters();
            LettresJouees();
            ShowErreurs();

        }
        public void GamePerdu()
        {
            Console.Clear();
            //ShowErreurs();
            Lose();
            GameReplay();
        }
        public void GameReplay()
        {

            Console.WriteLine("  _____  ______     _  ____  _    _ ______ _____    ___  \n |  __ \\|  ____|   | |/ __ \\| |  | |  ____|  __ \\  |__ \\ \n | |__) | |__      | | |  | | |  | | |__  | |__) |    ) |\n |  _  /|  __| _   | | |  | | |  | |  __| |  _  /    / / \n | | \\ \\| |___| |__| | |__| | |__| | |____| | \\ \\   |_|  \n |_|  \\_\\______\\____/ \\____/ \\____/|______|_|  \\_\\  (_)  ");
            Console.WriteLine(" __     __      __  _   _ \n \\ \\   / /     / / | \\ | |\n  \\ \\_/ /     / /  |  \\| |\n   \\   /     / /   | . ` |\n    | |     / /    | |\\  |\n    |_|    /_/     |_| \\_|");

        }
        public void Lose()
        {
            Console.WriteLine("  _____  ______ _____  _____  _    _  \n |  __ \\|  ____|  __ \\|  __ \\| |  | | \n | |__) | |__  | |__) | |  | | |  | | \n |  ___/|  __| |  _  /| |  | | |  | | \n | |    | |____| | \\ \\| |__| | |__| | \n |_|    |______|_|  \\_\\_____/ \\____/ ");
        }
        public void Titre()
        {
            Console.WriteLine("\n _      ______   _____  ______ _   _ _____  _    _ \n| |    |  ____| |  __ \\|  ____| \\ | |  __ \\| |  | |\n| |    | |__    | |__) | |__  |  \\| | |  | | |  | |\n| |    |  __|   |  ___/|  __| | . ` | |  | | |  | |\n| |____| |____  | |    | |____| |\\  | |__| | |__| |\n|______|______| |_|    |______|_| \\_|_____/ \\____/ ");
        }
        public void GG()
        {
            Console.Clear();
            Console.WriteLine("     _____    _____   \n    / ____|  / ____|  \n   | |  __  | |  __   \n   | | |_ | | | |_ |  \n   | |__| | | |__| |  \n    \\_____|  \\_____|  ");
            GameReplay();



        }
        public void Bye()
        {
            Console.Clear();
            Console.WriteLine("  ____   __     __  ______     ____   __     __  ______     _          __\n |  _ \\  \\ \\   / / |  ____|   |  _ \\  \\ \\   / / |  ____|   | |    _   / /\n | |_) |  \\ \\_/ /  | |__      | |_) |  \\ \\_/ /  | |__      | |   (_) | | \n |  _ <    \\   /   |  __|     |  _ <    \\   /   |  __|     | |       | | \n | |_) |    | |    | |____    | |_) |    | |    | |____    |_|    _  | | \n |____/     |_|    |______|   |____/     |_|    |______|   (_)   (_) | | \n                                                                      \\_\\");

        }

        string[] pendu = new string[] { "\n",
            "\n      |\n      |   "
        , "\n      |\n      |\n      |",
         "\n      |\n      |\n      |\n      |\n      |",
          "\n  +---+\n  |   |\n      |\n      |\n      |\n      |",
           "\n  +---+\n  |   |\n  O   |\n      |\n      |\n      |",
            "\n  +---+\n  |   |\n  O   |\n  |   |\n      |\n      |",
            "\n  +---+\n  |   |\n  O   |\n /|   |\n      |\n      |",
            "\n  +---+\n  |   |\n  O   |\n /|\\  |\n      |\n      |",
             "\n  +---+\n  |   |\n  O   |\n /|\\  |\n /    |\n      |",
              "\n  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |" };



    }
}










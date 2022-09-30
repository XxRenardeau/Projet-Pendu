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
        public void ShowErreurs() //permet d'afficher les différentes étapes du pendu (appelé dans la fonction GameUI)
        {
            string PenduErreur = pendu[LogiqueUI.Erreurs];
            Console.WriteLine(PenduErreur);
            return;

        }
        public void ShowLetters()//permet d'afficher les différent espace ou il n'y a pas de lettres devinée (apelé dans la fonction GameUI)
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
        public void LettresJouees()//permet d'afficher les lettres fausses différente dans une liste(appelé dans la fonction GameUI)
        {
            string LettresJouees = string.Empty;
            for (int i = 0; i < LogiqueUI.AllInput.Count; i++)
            {
                LettresJouees += LogiqueUI.AllInput[i] + ",";
            }
            Console.WriteLine("\n \n" + LettresJouees);

        }
        public void GameUI()//contole la base de l'inteface
        {
            Console.Clear();
            Titre();
            ShowLetters();
            LettresJouees();
            ShowErreurs();

        }
        public void GamePerdu()//affiche l'interface si le joueur perd
        {
            Console.Clear();
            //ShowErreurs();
            Lose();
            GameReplay();
        }
        public void GG()//affiche l'interface si le joueur gagne affichant le texte ASCII disant "GG"
        {
            Console.Clear();
            Console.WriteLine("     _____    _____   \n    / ____|  / ____|  \n   | |  __  | |  __   \n   | | |_ | | | |_ |  \n   | |__| | | |__| |  \n    \\_____|  \\_____|  ");
            GameReplay();



        }
        public void GameReplay()//l'interface demandant si le joueur veut rejouer en affichant le texte ASCII disant "REJOUER ? Y/N"
        {

            Console.WriteLine("  _____  ______     _  ____  _    _ ______ _____    ___  \n |  __ \\|  ____|   | |/ __ \\| |  | |  ____|  __ \\  |__ \\ \n | |__) | |__      | | |  | | |  | | |__  | |__) |    ) |\n |  _  /|  __| _   | | |  | | |  | |  __| |  _  /    / / \n | | \\ \\| |___| |__| | |__| | |__| | |____| | \\ \\   |_|  \n |_|  \\_\\______\\____/ \\____/ \\____/|______|_|  \\_\\  (_)  ");
            Console.WriteLine(" __     __      __  _   _ \n \\ \\   / /     / / | \\ | |\n  \\ \\_/ /     / /  |  \\| |\n   \\   /     / /   | . ` |\n    | |     / /    | |\\  |\n    |_|    /_/     |_| \\_|");

        }
        public void Lose()//le texte ASCII disant "PERDU"
        {
            Console.WriteLine("  _____  ______ _____  _____  _    _  \n |  __ \\|  ____|  __ \\|  __ \\| |  | | \n | |__) | |__  | |__) | |  | | |  | | \n |  ___/|  __| |  _  /| |  | | |  | | \n | |    | |____| | \\ \\| |__| | |__| | \n |_|    |______|_|  \\_\\_____/ \\____/ ");
        }
        public void Titre()//le texte ASCII disant ""
        {
            Console.WriteLine("\n _      ______   _____  ______ _   _ _____  _    _ \n| |    |  ____| |  __ \\|  ____| \\ | |  __ \\| |  | |\n| |    | |__    | |__) | |__  |  \\| | |  | | |  | |\n| |    |  __|   |  ___/|  __| | . ` | |  | | |  | |\n| |____| |____  | |    | |____| |\\  | |__| | |__| |\n|______|______| |_|    |______|_| \\_|_____/ \\____/ ");
        }

        public void Bye()//le texte ASCII disant "BYE BYE :("
        {
            Console.Clear();
            Console.WriteLine("  ____   __     __  ______     ____   __     __  ______     _          __\n |  _ \\  \\ \\   / / |  ____|   |  _ \\  \\ \\   / / |  ____|   | |    _   / /\n | |_) |  \\ \\_/ /  | |__      | |_) |  \\ \\_/ /  | |__      | |   (_) | | \n |  _ <    \\   /   |  __|     |  _ <    \\   /   |  __|     | |       | | \n | |_) |    | |    | |____    | |_) |    | |    | |____    |_|    _  | | \n |____/     |_|    |______|   |____/     |_|    |______|   (_)   (_) | | \n                                                                      \\_\\");

        }
        public void AlreadyGuessed()
        {
            Console.Clear();
            GameUI();
            Console.WriteLine("VEULLIEZ ENTRER DES LETTRES QUE VOUS NAVEZ PAS DEJA DEVINE");



        }
        public void NotAlphabetic()
        {
            Console.Clear();
            GameUI();
            Console.WriteLine("VEULLIEZ ENTRER UNIQUEMENT DES LETTRES");



        }

        //tableau contenant les différentes étapes du dessin ASCII du pendu au fur et a mesure que le joeur ce trompe
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
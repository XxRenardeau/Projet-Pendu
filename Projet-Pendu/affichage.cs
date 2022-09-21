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
            Console.WriteLine("CECI EST UN TEST DE ERREUR TU SAIT" + PenduErreur);
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
            Console.WriteLine(Traits);
        }
        public void LettresJouees()
        {
            string LettresJouees = string.Empty;
            for (int i = 0; i < LogiqueUI.AllInput.Count; i++)
            {
                LettresJouees += LogiqueUI.AllInput[i]+ ",";
            }
            Console.WriteLine(LettresJouees);

        }
        public void GameUI()
        {
            Console.Clear();
            Titre();
            ShowLetters();
            LettresJouees();
            ShowErreurs();
        }
        public void Titre()
        {
            Console.WriteLine("\n _      ______   _____  ______ _   _ _____  _    _ \n| |    |  ____| |  __ \\|  ____| \\ | |  __ \\| |  | |\n| |    | |__    | |__) | |__  |  \\| | |  | | |  | |\n| |    |  __|   |  ___/|  __| | . ` | |  | | |  | |\n| |____| |____  | |    | |____| |\\  | |__| | |__| |\n|______|______| |_|    |______|_| \\_|_____/ \\____/ ");
        }

        string[] pendu = new string[] { "stade initial",
            "premier stage"
        , "deuxieme stage",
         "troisieme stage",
          "quatrieme stage",
           "cinquieme stage",
            "sixieme stage",
            "septieme stage",
            "huitieme stage",
             "neuvieme stage",
              "\n  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |" };



    }
}






/*
  +---+
  |   |
      |
      |
      |
      |

  +---+
  |   |
  O   |
      |
      |
      |

  +---+
  |   |
  O   |
  |   |
      |
      |

  +---+
  |   |
  O   |
 /|   |
      |
      |

  +---+
  |   |
  O   |
 /|\  |
      |
      |

  +---+
  |   |
  O   |
 /|\  |
 /    |
      |*/


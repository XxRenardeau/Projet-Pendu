using System;
using System.Collections;
using System.Collections.Generic;
using pendu;


namespace pendu
{
    class Coeur
    {

        public logique currentLogique;
        public affichages currentAffichage;
        public Coeur()
        {
            currentLogique = new logique();
            currentAffichage = new affichages();
            Console.WriteLine("ceci est un test");
            currentLogique.MainLogique();
        }

    }
}
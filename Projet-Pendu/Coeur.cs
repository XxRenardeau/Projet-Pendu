using System;
using System.Collections;
using System.Collections.Generic;
public logique currentLogique;
public affichage currentAffichage;

namespace Main
{
    class Main
    {
        public void Main()
        {
            currentLogique = new logique();
            currentAffichage = new affichage();
            console.WriteLine("ceci est un test");
            currentLogique.logique;
            currentAffichage.affichage;
        }

    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using pendu;


namespace pendu
{
    class Coeur
    {

        public logique currentLogique;
        
        public Coeur()
        {
            currentLogique = new logique();
            //Console.WriteLine("ceci est un test");
            currentLogique.MainLogique();
            
            
        }

    }
}
public class Mots
{
    string mot;
    public Mots(string mot) //met le mot en majuscule
    {
        this.mot = mot;
        this.mot = this.mot.ToUpper();
    }

    public bool Contient(char Lettre)//verifie si le mot contient une lettre spécifique
    {
        return mot.Contains(Lettre);
    }
    public char LettreIndex(int index) //utilisé dans l'affichage pour créé l'espace affichant les lettres
    {
        return mot[index];

    }
}
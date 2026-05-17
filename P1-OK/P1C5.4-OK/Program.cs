IDictionary<string, int> mois = new Dictionary<string, int>();

//string[] moisDeAnnee = {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"};
const string JUIN = "Juin";
const string SEPTEMBRE = "Septembre";
const string MARS = "Mars";

// TODO : Remplacer les noms par des constantes de type chaine de caractères
mois.Add(JUIN, 6);
mois.Add(SEPTEMBRE, 9);
mois.Add(MARS, 5);

// TODO : Corriger la valeur de Mars avec (3)
mois[MARS] = 3;

// TODO : Retirer Juin
mois.Remove(JUIN);

// Afficher le contenu du dictionnaire
Console.WriteLine("La liste des mois est :");
foreach (KeyValuePair<string, int> clePaire in mois)
{
    Console.WriteLine(clePaire.Key.ToString() + " est le numéro du mois de " + clePaire.Value + " de l'année ");
}
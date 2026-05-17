// TODO, étape 1 : instancier un objet de la classe Livre et affecter cet objet à une variable nommée monLivre
using P1C4;
var monLivre = new Livre;

/*ou
var monLivre = new Livre
{
    Titre = "Titre du livre",
    Auteur = "Nom de l'auteur",
    NombreDePages = 100
};
*/

// TODO, étape 2 : affecter une valeur aux champs titre, auteur et nombre de pages de votre objet
monLivre.Titre = "Titre du livre";
monLivre.Auteur = "Nom de l'auteur";
monLivre.NombreDePages = 100;

// Afficher le contenu des champs de cet objet 
Console.WriteLine($"Le titre du livre est {monLivre.Titre}");
Console.WriteLine($"Son auteur est {monLivre.Auteur}");
Console.WriteLine($"Il compte {monLivre.NombreDePages} pages");

using System.Numerics;

Livre leParfum = new Livre();
leParfum.auteur = ".";
leParfum.titre = "Le Parfum";
leParfum.prix = 12.99M;
leParfum.nombre_pages = 150;

Livre nemo = new Livre();
nemo.auteur = ".";
nemo.titre = "Le Monde De Némo";
nemo.prix = 6.70M;
nemo.nombre_pages = 34;

Livre spiral = new Livre();
spiral.auteur = ".";
spiral.titre = "Spiral";
spiral.prix = 17.25M;
spiral.nombre_pages = 65;

Livre barbe = new Livre();
barbe.auteur = ".";
barbe.titre = "Barbe bleu";
barbe.prix = 5.50M;
barbe.nombre_pages = 285;

Livre narnia = new Livre() ;
narnia.auteur = ".";
narnia.titre = "Narnia";
narnia.prix = 15.30M;
narnia.nombre_pages = 450;

List<Livre> listOfBooks = new List<Livre>() ;
listOfBooks.AddRange([leParfum, nemo, spiral, barbe, narnia]);

do
{

    decimal total = 0;

    for (int i = 0; i < listOfBooks.Count; i++)
    {
        Console.WriteLine($"{i} \t {listOfBooks[i].auteur} \t {listOfBooks[i].titre} \t {listOfBooks[i].prix} \t {listOfBooks[i].nombre_pages} \t ");
    }

    Console.WriteLine($"Votre panier est à {total} € ");
    int bookId;

    do
    {
        Console.WriteLine("Quel livre voulez-vous ajouter au panier?");
    } while (!int.TryParse(Console.ReadLine() , out bookId) || bookId<0 || bookId >=listOfBooks.Count);



    total += listOfBooks[bookId].prix;

} while (true) ;


    public struct Livre
    {
        public string auteur, titre;
        public ushort nombre_pages;
        public decimal prix;
    }



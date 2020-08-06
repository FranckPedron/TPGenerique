using System;

namespace TPGenerique
{
    class Program
    {
        static void Main(string[] args)
        {
            ListeChainee<int> list = new ListeChainee<int>();

            list.Ajouter(5);
            list.Ajouter(10);
            list.Ajouter(4);
            Console.WriteLine(list.Premier.Valeur);
            Console.WriteLine(list.Premier.Suivant.Valeur);
        }
    }
}

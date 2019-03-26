using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvennue dans ce jeux de Morpion choisissez le nombre de case:  ");
            int nombreDecase= Int32.Parse(Console.ReadLine());
          
            Morpion Monmorpion = new Morpion(nombreDecase);
            //Monmorpion.Cases = new MaCase[3, 3];
            //Monmorpion.SymboleDujoueurCourant = Symbole.Croix;
            //for (int u = 0; u < 3; u++)
            //{
            //    for (int v = 0; v < 3; v++)
            //    {
            //        MaCase macase = new MaCase();
            //        macase.Symbolecourant = null;
            //        Monmorpion.Cases[u, v] = macase;
            //    }
            //}
            while (0 < 1)
            {

                Fonction.AfficherMorpion(Monmorpion)
               ;
                Console.Write("\n");
                Console.WriteLine("Entrez i:");
                int i = Int32.Parse(Console.ReadLine());
                Console.Write("\n");
                Console.WriteLine("Entrez j:");
                int j = Int32.Parse(Console.ReadLine());
                Tour tour = new Tour(i,j);
                
                Fonction.jouerUneCase(Monmorpion, tour);
                if (Fonction.DeterminerSymbolGagnant(Monmorpion) == null)
                {
                    Console.WriteLine("continuez la partie");
                }
                else if (Fonction.DeterminerSymbolGagnant(Monmorpion) == Symbole.Croix)
                {
                    Console.WriteLine("Le  le symbole gagnant est la Ccroix");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Le  le symbole gagnant est le rond"); Console.ReadKey();
                    break;
                }

            }
        }
    }
}

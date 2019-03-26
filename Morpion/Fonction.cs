using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
   public class Fonction
    {
        public static bool AffecterSymbole(MaCase caseCourante,Symbole symboleAtribuer)
        {
            bool TesteSiVide = true;
            if (caseCourante.Symbolecourant == null)
            { caseCourante.Symbolecourant = symboleAtribuer; }
            else { TesteSiVide = false; }


            return TesteSiVide;

        }

        public static void jouerUneCase(Morpion grille, Tour PositionDeLacase)
        {

            MaCase CaseAjouer = grille.Cases[PositionDeLacase.i, PositionDeLacase.j];

           
            if (AffecterSymbole(CaseAjouer, grille.SymboleDujoueurCourant)==true)
            {
                Symbole symboleDuProchainJoueur = grille.SymboleDujoueurCourant == Symbole.Croix ? Symbole.Rond : Symbole.Croix;
                grille.SymboleDujoueurCourant = symboleDuProchainJoueur;
            }
           
        }

        //public static Symbole? DeterminerSymbolegagnant(Morpion morpion)
        //{

        //  for(int i = 0; i < 3; i++)
        //{
        // int j = 0;
        //Symbole? resultat;

        //if (morpion.Cases[i, j].Symbolecourant == morpion.Cases[i, j + 1].Symbolecourant && morpion.Cases[i, j + 1].Symbolecourant == morpion.Cases[i, j + 2].Symbolecourant) { resultat = morpion.Cases[i, j].Symbolecourant; }

        //   else if(morpion.Cases[i, i].Symbolecourant == morpion.Cases[i+1,i].Symbolecourant && morpion.Cases[i+1, i].Symbolecourant == morpion.Cases[i+2, i].Symbolecourant)
        //  {
        //         resultat = morpion.Cases[0, i].Symbolecourant;
        //     }else if()
        //            if (morpion.Cases[0, 0].Symbolecourant != null
        //                           && morpion.Cases[0, 0].Symbolecourant == morpion.Cases[1, 1].Symbolecourant
        //                           && morpion.Cases[0, 0].Symbolecourant == morpion.Cases[2, 2].Symbolecourant)
        //            {
        //                return morpion.Cases[0, 0].Symbolecourant;
        //            }


        //        if (morpion.Cases[2, 0].Symbolecourant != null
        //            && morpion.Cases[2, 0].Symbolecourant == morpion.Cases[1, 1].Symbolecourant
        //            && morpion.Cases[2, 0].Symbolecourant == morpion.Cases[0, 2].Symbolecourant)
        //        {
        //            return morpion.Cases[0, 0].Symbolecourant;
        //        }


        //        return resultat;



        //  }

        //}
        public static Symbole? DeterminerSymbolGagnant(Morpion morpion)
        {
            //Pour chaques lignes
            //  si toutes les cases de cette ligne ont le même symboles 
            //  et que ce symbole n'est pas "vide"
            //      alors le symbol gagnant est le symbol de la 1ère case de la ligne
            //      je retourne le symbole gagnant
            for (int indexLigne = 0; indexLigne < morpion.Cases.GetLength(0); indexLigne++)
            {
                //for(int T=0; T< morpion.Cases.GetLength(0); T++)
                
                    //for(int r=0;r< morpion.Cases.GetLength(0); r++)
                    //{
                    // = morpion.Cases[indexLigne, r].Symbolecourant;

                    //    if (morpion.Cases[indexLigne, r].Symbolecourant != null &&)
                    //{
                       

                    //}
                                            
                        




                    //}




                

                

                if (morpion.Cases[indexLigne, 0].Symbolecourant != null &&
                    morpion.Cases[indexLigne, 0].Symbolecourant == morpion.Cases[indexLigne, 1].Symbolecourant
                    && morpion.Cases[indexLigne, 0].Symbolecourant == morpion.Cases[indexLigne, 2].Symbolecourant)
                {
                    return morpion.Cases[indexLigne, 0].Symbolecourant;
                }
            }

            //Pour chaques colonnes
            //  si toutes les cases de cette colonne ont le même symboles
            //  et que ce symbole n'est pas "vide"
            //      alors le symbole gagnant est le symbole de la 1ère case de la colonne
            //      je retourne le symbole gagnant

            for (int indexColonne = 0; indexColonne < 3; indexColonne++)
            {
                if (morpion.Cases[0, indexColonne].Symbolecourant != null &&
                    morpion.Cases[0, indexColonne].Symbolecourant == morpion.Cases[1, indexColonne].Symbolecourant
                    && morpion.Cases[0, indexColonne].Symbolecourant == morpion.Cases[2, indexColonne].Symbolecourant)
                {
                    return morpion.Cases[0, indexColonne].Symbolecourant;
                }
            }

            //Pour les 2 diagonales
            //  si toutes les cases de cette diagonale ont le même symboles
            //  et que ce symbole n'est pas "vide"
            //      alors le symbole gagnant est le symbole de la 1ère case de la diagonale
            //      je retourne le symbole gagnant

            if (morpion.Cases[0, 0].Symbolecourant != null
                && morpion.Cases[0, 0].Symbolecourant == morpion.Cases[1, 1].Symbolecourant
                && morpion.Cases[0, 0].Symbolecourant == morpion.Cases[2, 2].Symbolecourant)
            {
                return morpion.Cases[0, 0].Symbolecourant;
            }


            if (morpion.Cases[2, 0].Symbolecourant != null
                && morpion.Cases[2, 0].Symbolecourant == morpion.Cases[1, 1].Symbolecourant
                && morpion.Cases[2, 0].Symbolecourant == morpion.Cases[0, 2].Symbolecourant)
            {
                return morpion.Cases[0, 0].Symbolecourant;
            }

            //Sinon
            //  Il n'y a aucun gagnant
            return null;




        }

        public static void AfficherMorpion(Morpion morpionGrille)
        {
            Console.Clear();
            for (int i = 0; i < morpionGrille.Cases.GetLength(0); i++)
            {
                for (int j = 0; j < morpionGrille.Cases.GetLength(0); j++)
                {

                    if (morpionGrille.Cases[i, j].Symbolecourant == Symbole.Croix)
                    {
                        Console.Write("X|");


                    }
                    else if (morpionGrille.Cases[i, j].Symbolecourant == Symbole.Rond)
                    {
                        Console.Write("O|");



                    }
                    else { Console.Write("_|"); }


                }
                Console.Write("\n");

            }
            if (morpionGrille.SymboleDujoueurCourant == Symbole.Rond)
            {
                Console.Write("le prochain joueur est : O");


            }
            else { Console.Write("le prochain joueur est : X"); }



        }
    }














}




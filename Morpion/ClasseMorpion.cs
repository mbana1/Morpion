using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    public class Morpion
    {
        public MaCase[,] Cases { get; private set; }
        public Symbole SymboleDujoueurCourant;


        public Morpion(int lig, Symbole choix)
        {


            this.Cases = new MaCase[lig, lig];
            this.SymboleDujoueurCourant = choix;
            for (int u = 0; u < lig; u++)
            {
                for (int v = 0; v < lig; v++)
                {
                    MaCase macase = new MaCase();
                    macase.Symbolecourant = null;
                    this.Cases[u, v] = macase;
                }
            }

        }
        public Morpion(int lig) : this(lig,Symbole.Croix)
        {
           


        }




            public Morpion() : this(3)
        {





            ////this.Cases = new MaCase[3, 3];
            ////this.SymboleDujoueurCourant = Symbole.Croix;
            //for (int u = 0; u < 3; u++)
            //{
            //    for (int v = 0; v < 3; v++)
            //    {
            //        MaCase macase = new MaCase();
            //        macase.Symbolecourant = null;
            //        this.Cases[u, v] = macase;
            //    }
            //}




        }
    }

    public class MaCase
    {
        public Symbole? Symbolecourant;
        //public bool AffecterSymbole(Symbole symboleAtribuer)
        //{
        //    bool TesteSiVide = true;
        //    if (this.Symbolecourant == null)
        //    { this.Symbolecourant = symboleAtribuer; }
        //    else { TesteSiVide = false; }


        //    return TesteSiVide;

        //}

    }
    public class Tour
    {
        public int i;
        public int j;
        public Tour(int I, int J)
        {
            i = I;
            j = J;
        }

    }
    public enum Symbole
    {
        Croix,
        Rond

    }
}

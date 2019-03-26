using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDuMorpionEtaInitiale()
        {
            Morpion.Morpion Monmorpion = new Morpion.Morpion();
            Assert.IsTrue(Monmorpion.SymboleDujoueurCourant==Morpion.Symbole.Croix, "le symbole qui dois commencer n'est pas la croix");
        }
        [TestMethod]
        public void TestJouerUnTour()
        {
            Morpion.Morpion Monmorpion = new Morpion.Morpion();
            Morpion.Tour tour = new Morpion.Tour(1, 1);
            Morpion.Fonction.jouerUneCase(Monmorpion, tour);
            Assert.IsTrue(Monmorpion.SymboleDujoueurCourant == Morpion.Symbole.Croix && Monmorpion.Cases., "le symbole qui dois




        }




    }

}

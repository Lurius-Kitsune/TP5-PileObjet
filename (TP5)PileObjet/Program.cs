using _TP5_PileObjet.Tests;
using MesOutils;
using System;
using Utilitaires;

namespace _TP5_PileObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPile.TestePileVide();
            TestPile.TesteEmpiler();
            TestPile.TesteEmpilerDepiler();

            ////Test de SaisirNB
            //int nbSaisi = Utilitaire.SaisirNb();
            //Console.WriteLine($"Nombre saisie : {nbSaisi} ");
            //nbSaisi = Utilitaire.SaisirNb(10);
            //Console.WriteLine($"Nombre saisie : {nbSaisi} ");
            //nbSaisi = Utilitaire.SaisirNb(10, 30);
            //Console.WriteLine($"Nombre saisie : {nbSaisi} ");
            //Console.WriteLine("[Info]Fin du programme");

            TestPile.TesteConversion();
            Console.ReadKey();
        }

    }
}

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

            TesteConversion();
            Console.ReadKey();
        }


        /// <summary>
        /// Test de la méthode Conversion(...)
        /// Cette méthode permet la saisie des valeurs utilise à la conversion :
        /// nombre d'éléments de la collection,
        /// nombre à convertir,
        /// nouvelle base
        /// </summary>
        static void TesteConversion()
        {
            int nombre, nBase;
            Console.WriteLine("[Nombre à convertir]");
            nombre = Utilitaire.SaisirNb();
            Console.WriteLine("[Base]");
            nBase = Utilitaire.SaisirNb(2, 16);
            try
            {
                Console.WriteLine(Utilitaire.Convertir(nombre, nBase));
            }
            catch (Exception ex) { Console.WriteLine("[Erreur] {0}", ex.Message); }
        }


    }
}

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
            TestPile.TestePileVidePleine();
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
                Console.WriteLine(Convertir(nombre, nBase));
            }
            catch (Exception ex) { Console.WriteLine("[Erreur] {0}", ex.Message); }
        }

        /// <summary>
        /// Convertit un nombre de base 10 en base 2 et 16
        /// </summary>
        /// <param name="NbElements">Nombre d'éléments de la pile</param>
        /// <param name="NbAConvertir">Nombre à convertir</param>
        /// <param name="pNewbase">Nouvelle base du nombre</param>
        /// <returns></returns>
        static string Convertir(int NbAConvertir, int pNewbase)
        {
            Pile<int> pile = new Pile<int>();
            string result = "";
            int premierNombre = NbAConvertir;
            while (!(NbAConvertir / pNewbase == 0))
            {
                pile.Empiler(NbAConvertir % pNewbase);
                NbAConvertir /= pNewbase;
            }
            while (!pile.PileVide())
            {
                int i = (int)pile.Depiler();
                if (i <= 10)
                {
                    result += i;
                }
                else
                {
                    result += i.ToString("X");
                }
            }
            return "La valeur de " + premierNombre + " (base 10) vaut " + result + " en base " + pNewbase; ;
        }
    }
}

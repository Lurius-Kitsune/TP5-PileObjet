using MesOutils;
using System;

namespace _TP5_PileObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            TestePileVidePleine(5);
            TestePileVidePleine(0);
            TesteEmpiler(20);
            TesteEmpiler(2);
            TesteEmpilerDepiler(20);
            Console.WriteLine("[Info]Fin du programme");
            Console.ReadKey();
        }
        ///
        static void TestePileVidePleine(int nbElements)
        {
            Pile unePile = new Pile(nbElements);
            if (unePile.PileVide())
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (unePile.PilePleine())
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }
        }

        /// <summary>
        /// Test de la méthode Empiler
        /// </summary>
        /// <param name="nbElements">Nombre d'éléments maximum de la pile</param>
        static void TesteEmpiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
                unePile.Empiler(2);
                unePile.Empiler(14);
                unePile.Empiler(6);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        /// <summary>
        /// Test d'empiler - dépiler
        /// </summary>
        /// <param name="nbElements">Nombre d'éléments maximum de la pile</param>
        static void TesteEmpilerDepiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
                unePile.Empiler(2);
                unePile.Empiler(22);
                int valeurDepilee = unePile.Depiler();
                Console.WriteLine("valeur dépilée : " + valeurDepilee);
                unePile.Empiler(2);
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

﻿using MesOutils;
using System;
using Utilitaires;

namespace _TP5_PileObjet.Tests
{
    internal abstract class TestPile
    {
        public static void TestePileVide()
        {
            Pile<int> unePile = new Pile<int>();
            if (unePile.PileVide())
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
        }

        /// <summary>
        /// Test de la méthode Empiler
        /// </summary>
        public static void TesteEmpiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                unePile.Empiler(2);
                unePile.Empiler(14);
                unePile.Empiler(6);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        /// <summary>
        /// Test d'empiler - dépiler
        /// </summary>
        public static void TesteEmpilerDepiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
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

        /// <summary>
        /// Test de la méthode Conversion(...)
        /// Cette méthode permet la saisie des valeurs utilise à la conversion :
        /// nombre d'éléments de la collection,
        /// nombre à convertir,
        /// nouvelle base
        /// </summary>
        public static void TesteConversion()
        {
            int nombre, nBase;
            Console.WriteLine("[Nombre à convertir]");
            nombre = Utilitaire.SaisirNb();
            Console.WriteLine("[Base]");
            nBase = Utilitaire.SaisirNb(2, 16);
            TesteConversion(nombre, nBase);
        }
        public static void TesteConversion(int nbAConvertir, int newBase)
        {
            try
            {
                Console.WriteLine(Utilitaire.Convertir(nbAConvertir, newBase));
            }
            catch (Exception ex) { Console.WriteLine("[Erreur] {0}", ex.Message); }
        }

    }
}

using MesOutils;
using System;

namespace Utilitaires
{
    public static class Utilitaire
    {
        public static int SaisirNb()
        {
            int nb = 0;
            try
            {
                Console.WriteLine("Veuillez saisir un nombre entier : ");
                nb = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) { Console.WriteLine("[Erreur FormatException] la valeur par défaut sera à 1"); };
            return nb;
        }

        public static int SaisirNb(int pMin)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.WriteLine($"Veuillez saisir un nombre entier de minimum {pMin}: ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin);
            return nb;
        }

        public static int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.WriteLine($"Veuillez saisir un nombre entier compris entre {pMin} et {pMax}: ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin || nb > pMax);
            return nb;
        }

        /// <summary>
        /// Convertit un nombre de base 10 en base 2 et 16
        /// </summary>
        /// <param name="NbAConvertir">Nombre à convertir</param>
        /// <param name="pNewbase">Nouvelle base du nombre</param>
        /// <returns></returns>
        public static string Convertir(int NbAConvertir, int pNewbase)
        {
            if (NbAConvertir <= 0) { throw new Exception("Le nombre à convertir doit être strictement positif"); }
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

        /// <summary>
        /// Code améliorer de la methode InversePhrase
        /// </summary>
        /// <param name="phrase">La phrase à inverser</param>
        /// <returns>La phrase inverser</returns>
        public static string InversePhrase(String phrase)
        {
            var tab = phrase.Split(' ');
            Array.Reverse(tab);
            return String.Join(" ", tab);
        }
    }
}


using System;

namespace Utilitaires
{
    public abstract class Utilitaire
    {
        public static int SaisirNb()
        {
            int nb = 0;
            try
            {
                Console.WriteLine("Veuillez saisir un nombre entier : ");
                nb = Convert.ToInt32(Console.ReadLine());
            } 
            catch (FormatException) { };
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
            } while (nb >= pMin);
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
            } while (nb >= pMin && nb <= pMax);
            return nb;
        }
    }
}

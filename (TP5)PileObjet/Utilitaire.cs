using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitaires
{
    public abstract class Utilitaire
    {
        public int SaisirNb()
        {
            Console.WriteLine("Veuillez saisir un nombre entier : ");
            int nb = Convert.ToInt32(Console.ReadLine());
            return nb;
        }

        public int SaisirNb(int pMin)
        {
            int nb = 0;
            while (nb >= pMin)
            {
                Console.WriteLine($"Veuillez saisir un nombre entier de minimum {pMin}: ");
                nb = Convert.ToInt32(Console.ReadLine());
            }
            return nb;
        }

        public int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            while (nb >= pMin && nb <= pMax)
            {
                Console.WriteLine($"Veuillez saisir un nombre entier compris entre {pMin} et {pMax}: ");
                nb = Convert.ToInt32(Console.ReadLine());
            }
            return nb;
        }
    }
}

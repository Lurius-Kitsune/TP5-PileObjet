using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP5_PileObjet
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void TestePileVidePleine(int nbElements)
        {
            Pile unePile = new Pile(10);
            if (unePile)
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (PilePleine(unePile))
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }
        }
    }
}

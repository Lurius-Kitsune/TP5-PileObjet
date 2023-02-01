using System;
using System.Collections.Generic;

namespace _TP5_PileObjet
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté
    /// On retire toujours le dernier élément ajouté
    /// </summary>
    class Pile
    {   
        /// <summary>
        /// Nombre maximum d'éléments de la Pile
        /// </summary>
        private int nbMaxElt;

        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private List<int> elements;

        /// <summary>
        /// Constructeur de la classe Pile
        /// </summary>
        /// <param name="nbMaxElt">Taille maximum de la pile</param>
        public Pile(int nbMaxElt)
        {
            this.nbMaxElt = nbMaxElt;
            this.elements = new List<int>();
        }

        /// <summary>
        /// retourne un booléen indiquant si la pile est vide.
        /// Une pile est vide si le nombre d'élément 
        /// contenue dans tabElem est égale à 0
        /// </summary>
        /// <returns></returns>
        public bool PileVide()
        {
            return this.elements.Count == 0;
        }

        /// <summary>
        /// retourne un booléen indiquant si la pile est pleine.
        /// Une pile est vide si le nombre d'élément 
        /// contenue dans tabElem est égale à unePile.maxElt
        /// </summary>
        /// <returns></returns>
        public bool PilePleine()
        {
            return this.elements.Count >= this.nbMaxElt;
        }

        /// <summary>
        /// Cette méthode ajoute la valeur passée en paramètre au sommet de la pile
        /// Si la pile n'est pas pleine.
        /// Si la pile est pleine, déclenchement d'une exception.
        /// </summary>
        /// <param name="nb">élément à empiler</param>
        public void Empiler(int nb)
        {
            if (PilePleine())
            {
                // Informer que la pile est pleine !
                throw new Exception("[Erreur] Pile pleine, impossible d'empiler un élément");
            }
            else
            {
                this.elements.Add(nb);
            }
        }

        /// <summary>
        /// Renvoie la valeur située au sommet de la pile
        /// Si la pile est vide, la méthode déclenche une Exception.
        /// </summary>
        /// <param name="unePile">Pile sur laquelle il faut depiler</param>
        /// <returns>Valeur dépilée</returns>
        public object Depiler()
        {
            if (PileVide())
            {
                throw new Exception("[Erreur] Pile vide, impossible de dépiler un élément");
            }
            else
            {
                object valeur = this.elements[this.elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count - 1);
                return valeur;
            }
        }
    }
}

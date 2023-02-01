using System;
using System.Collections.Generic;

namespace MesOutils
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté
    /// On retire toujours le dernier élément ajouté
    /// </summary>
    class Pile<T>
    {
        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private List<T> elements;


        /// <summary>
        /// Constructeur de la classe <see cref="Pile"/>.
        /// </summary>
        /// <param name="nbMaxElt">Taille maximum de la pile</param>
        public Pile()
        {
            this.elements = new List<T>();
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
        /// Cette méthode ajoute la valeur passée en paramètre au sommet de la pile
        /// Si la pile n'est pas pleine.
        /// Si la pile est pleine, déclenchement d'une exception.
        /// </summary>
        /// <param name="valeur">élément à empiler</param>
        public void Empiler(T valeur)
        {
           this.elements.Add(valeur);
        }

        /// <summary>
        /// Renvoie la valeur située au sommet de la pile
        /// Si la pile est vide, la méthode déclenche une Exception.
        /// </summary>
        /// <param name="unePile">Pile sur laquelle il faut depiler</param>
        /// <returns>Valeur dépilée</returns>
        public int Depiler()
        {
            if (PileVide())
            {
                throw new Exception("[Erreur] Pile vide, impossible de dépiler un élément");
            }
            else
            {
                int valeur = this.elements[this.elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count - 1);
                return valeur;
            }
        }
    }
}

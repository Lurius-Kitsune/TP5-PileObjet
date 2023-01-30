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
    }
}

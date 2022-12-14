using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Joueur
    {
        public List<Personnage> personnages { get; set; }
        public string Nom { get; set; }

        public Joueur(string nom)
        {
            Nom = nom;
        } 
    }
}

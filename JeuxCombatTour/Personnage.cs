using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Personnage 
    {
        public int PV { get; set; }
        public int Vitesse { get; set; }
        public int Attaque { get; set; }
        public int AttaqueSpeciale { get; set; }

        public Personnage(int pv , int vitesse , int attaque , int attaqueSpeciale) {
        
            this.PV = pv;
            Vitesse = vitesse;
            Attaque = attaque;
            AttaqueSpeciale = attaqueSpeciale;
        
        } 


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public abstract class Personnage 
    {
        public int PV { get; set; }
        public int Vitesse { get; set; }
        public int Attaque { get; set; }
        public int AttaqueSpeciale { get; set; }
        public bool Mort = false;

        public Personnage(int pv , int vitesse , int attaque , int attaqueSpeciale, bool mort) {
        
            this.PV = pv;
            Vitesse = vitesse;
            Attaque = attaque;
            AttaqueSpeciale = attaqueSpeciale;
            Mort = mort;
        
        }

        public abstract void Attaquer();
    }
}

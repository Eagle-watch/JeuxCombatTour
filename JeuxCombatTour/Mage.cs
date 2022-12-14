using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Mage : Personnage
    {

        public new int PV = 24;
        public int vitesse = 5; 
        public int attaque = 6;
        public int attaqueSpeciale = 2;

        public Mage(int pv, int vitesse, int attaque, int attaqueSpeciale) : base(pv, vitesse, attaque, attaqueSpeciale)
        {
            PV = pv;
            Vitesse= vitesse;
            Attaque= attaque;
            AttaqueSpeciale= attaqueSpeciale;
        }

    }
}

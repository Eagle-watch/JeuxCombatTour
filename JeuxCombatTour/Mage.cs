using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Mage : Personnage
    {
        public Mage(int pv, int vitesse, int attaque, int attaqueSpeciale) : base(pv, vitesse, attaque, attaqueSpeciale)
        {
            PV = pv;
            Vitesse= vitesse;
            Attaque= attaque;
            AttaqueSpeciale= attaqueSpeciale;
        }

        public void AttaqueMage()
        {

            int AttaqueMage = Attaque = 6;

        }

        public void VitesseMage()
        {

            int VitesseMage =  Vitesse = 5; 

        }
    }
}

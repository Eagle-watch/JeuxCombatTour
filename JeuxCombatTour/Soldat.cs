using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Soldat : Personnage
    {
        public Soldat(int pv, int vitesse, int attaque, int attaqueSpeciale) : base(pv, vitesse, attaque, attaqueSpeciale)
        {
            PV = pv;
            Attaque = attaque;
            Vitesse = vitesse;
            attaqueSpeciale = AttaqueSpeciale;
        }

        public void AttaqueSoldat ()
        {



        }
    }
}

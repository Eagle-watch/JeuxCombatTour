using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Soigneur : Personnage
    {

        public Soigneur() 
        {
            PV = 20;
            Vitesse = 4;
            Attaque = 3;
            AttaqueSpeciale = 3;
            Mort = false;
            Nom = "Soigneur";
            AttaqueOn = true;
        }
    }
}

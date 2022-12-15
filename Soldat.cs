using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Soldat : Personnage
    {
        public Soldat() 
        {
            PV = 30;
            Attaque = 5;
            Vitesse = 6;
            AttaqueSpeciale = 2;
            Mort = false;
            Nom = "Soldat";
            AttaqueOn = true;
        }

    }
}

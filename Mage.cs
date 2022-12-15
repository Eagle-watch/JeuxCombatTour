using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Mage : Personnage
    {

        public Mage()
        {
            PV = 24;
            Vitesse= 5;
            Attaque= 6;
            AttaqueSpeciale= 2;
            Mort= false;
            Nom = "Mage";
            AttaqueOn = true;
        }


    }
    //Soigneur(PV: 20, Attaque: 3, Vitesse: 4, Cooldown special attaque: 3)
    //- Mage(PV: 24, Attaque: 6, Vitesse: 5, Cooldown special attaque: 2)
    //- Guerrier(PV: 30, Attaque: 5, Vitesse: 6, Cooldown special attaque: 2)
}

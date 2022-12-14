using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Mage : Personnage
    {

        public Mage(int pv, int vitesse, int attaque, int attaqueSpeciale, bool mort) : base(pv, vitesse, attaque, attaqueSpeciale , mort)
        {
            PV = pv;
            Vitesse= vitesse;
            Attaque= attaque;
            AttaqueSpeciale= attaqueSpeciale;
            Mort= mort;
        }

        //public override void Attaquer()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

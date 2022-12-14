using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Soldat : Personnage
    {
        public Soldat(int pv, int vitesse, int attaque, int attaqueSpeciale, bool mort) : base(pv, vitesse, attaque, attaqueSpeciale , mort)
        {
            PV = pv;
            Attaque = attaque;
            Vitesse = vitesse;
            AttaqueSpeciale = attaqueSpeciale;
            Mort= mort;
        }

        //public override void Attaquer()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

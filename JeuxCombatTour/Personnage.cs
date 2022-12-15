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

        public String Nom { get; set; }

        public bool AttaqueOn { get; set; }



        public void Attaquer(Personnage perso)
        {
            Console.WriteLine("Perso qui attaque : " + Nom);
            perso.PV -= Attaque;
            perso.MortPersonnage();
            Console.WriteLine("Perso qui est attaquer : " + perso.Nom);
            Console.WriteLine("PV du perso attaquer : " + perso.PV);
            this.AttaqueOn = false;

        }


        public void MortPersonnage()
        {
            if (PV <= 0)
            {
                PV = 0;
                Mort = true;
            }
        }

        public bool EstMort()
        {

            return this.Mort;

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Joueur
    {
        public List<Personnage> personnages { get; set; }
        public string Nom { get; set; }

        public Joueur(string nom)
        {
            Nom = nom;
            personnages= new List<Personnage>();
            choixperso();
            choixperso();
            choixperso();
            personnages = personnages.OrderByDescending(p => p.Vitesse).ToList();


        } 

        public void choixperso ()
        {
            Console.WriteLine("Choisir un Mage(1) , Soigneur(2) , Soldat(3)");

            var Personnage1 = Console.ReadLine();
            if (Personnage1 == "1")
            {
                personnages.Add(new Mage());
                Console.WriteLine("Vous avez choisi un Mage");
            }
            else if (Personnage1 == "2")
            {   
                personnages.Add(new Soigneur());
                Console.WriteLine( "Vous avez choisi un soigneur");
            }
            else if (Personnage1 == "3") 
            {
                personnages.Add(new Soldat());
                Console.WriteLine("Vous avez choisi un Soldat");
            }
        }

    }
}

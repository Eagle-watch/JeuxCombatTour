using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombatTour
{
    public class Jeux
    {
        public List<Joueur> Joueurs { get; set; }

        public Jeux()
        {
            Joueurs = new List<Joueur>();

            Console.WriteLine("Veuillez choisir le nom du premier joueur");
            var Joueur1 = Console.ReadLine();
            Joueurs.Add(new Joueur(Joueur1));

            Console.WriteLine("Veuillez choisir le nom du deuxième joueur");
            var Joueur2 = Console.ReadLine();
            Joueurs.Add(new Joueur(Joueur2));

        }

    }
}

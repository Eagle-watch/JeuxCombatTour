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

            while (Joueurs[0].personnages.Any(p => !p.Mort ) || Joueurs[1].personnages.Any(p => !p.Mort)) 
            {
            
                var PersoJ1 = Joueurs[0].personnages.FirstOrDefault(p => !p.Mort && p.AttaqueOn);
                var PersoJ2 = Joueurs[1].personnages.FirstOrDefault(p => !p.Mort && p.AttaqueOn);
                if (PersoJ1 == null) 
                {
                    PersoJ1 = Joueurs[0].personnages.FirstOrDefault(p => !p.Mort);
                }
                if (PersoJ2 == null)
                {
                    PersoJ2 = Joueurs[1].personnages.FirstOrDefault(p => !p.Mort);
                }

                if (PersoJ1 != null && PersoJ2 != null) 
                { 

                PersoJ1.Attaquer(PersoJ2);
                PersoJ2.Attaquer(PersoJ1);
                
                }

                PersoJ1 = Joueurs[0].personnages.FirstOrDefault(p => !p.Mort && p.AttaqueOn);
                PersoJ2 = Joueurs[1].personnages.FirstOrDefault(p => !p.Mort && p.AttaqueOn);
                if (PersoJ1 == null)
                {
                    PersoJ1 = Joueurs[0].personnages.FirstOrDefault(p => !p.Mort);
                }
                if (PersoJ2 == null)
                {
                    PersoJ2 = Joueurs[1].personnages.FirstOrDefault(p => !p.Mort);
                }

                if (PersoJ1 != null && PersoJ2 != null)
                {

                    PersoJ1.Attaquer(PersoJ2);
                    PersoJ2.Attaquer(PersoJ1);

                }


                PersoJ1 = Joueurs[0].personnages.FirstOrDefault(p => !p.Mort && p.AttaqueOn);
                PersoJ2 = Joueurs[1].personnages.FirstOrDefault(p => !p.Mort && p.AttaqueOn);
                if (PersoJ1 == null)
                {
                    PersoJ1 = Joueurs[0].personnages.FirstOrDefault(p => !p.Mort);
                }
                if (PersoJ2 == null)
                {
                    PersoJ2 = Joueurs[1].personnages.FirstOrDefault(p => !p.Mort);
                }

                if (PersoJ1 != null && PersoJ2 != null)
                {

                    PersoJ1.Attaquer(PersoJ2);
                    PersoJ2.Attaquer(PersoJ1);

                }

                Joueurs[0].personnages.ForEach(p => p.AttaqueOn= true);
                Joueurs[1].personnages.ForEach(p => p.AttaqueOn = true);
            }

            Console.WriteLine("Le Combat est terminé");

            //while Boucle jusqu'a ce que les perso soit Mort joueeur 0
            // On doit verifier que le personnage soit pas mort pour l'empecher d'attaquer si mort 
            
        }

    }
}

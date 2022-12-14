using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JeuxCombatTour
{
    internal class Fichemetier
    {

# Evaluation pratique

## Objectifs
        Vous devez faire un projet console en orienté objet qui permet de faire jouer à un jeu de combat au tour par tour.

## Fonctionnalités premières
        Voici les fonctionnalités attendues par votre jeu de combat :
- Deux joueurs sélectionnent 3 personnages au début du combat parmis :
    - Soigneur(PV: 20, Attaque: 3, Vitesse: 4, Cooldown special attaque: 3)
    - Mage(PV: 24, Attaque: 6, Vitesse: 5, Cooldown special attaque: 2)
    - Guerrier(PV: 30, Attaque: 5, Vitesse: 6, Cooldown special attaque: 2)
- Le joueur 1 joue en premier
- Les joueurs jouent un tour chacun avec un personnage
- Les personnages attaquent en fonction de leur vitesse
- Les personnages ont une attaque spéciale : 
    - Le soigneur soigne 8 PV au personnage ayant les PV le plus bas
    - Le mage fait double dégat
    - Le guerrier a un bouclier qui divise par deux les dégats reçus
- Cette attaque spéciale a un cooldown(voir ci-dessus)
- Le combat se termine lorsque l'un ou l'autre des joueurs n'a plus de personnage en vie
- Les personnages morts ne peuvent plus attaquer ni être attaqués.
- Le but est de faire en sorte que le combat se fasse de manière automatisé (donc sans choix utilisateur, sauf pour la sélection de personnage)

Bon courage et bons dévs à toutes et à tous !
    }
}

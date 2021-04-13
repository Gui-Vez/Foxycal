using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un script complémentaire avec gestionViePersonnage. Celui-ci gère la valeur du slider
 * afin d'avoir un visuel sur combien de dégâts le personnage prend.
 * Dernière modification: 23 mars 2021
 ****************************************************************************************************/

public class barreDeVieScript : MonoBehaviour
{
    public Slider barreVie;

    // Reset la valeur maximale pour assurer qu'à chaque fois le personnage revient à sa vie maximale au lancement du jeu
    public void vieMax(int vie)
    {
        barreVie.maxValue = vie;
        barreVie.value = vie;
    }

    // Associer la valeur du slider à sa valeur de vie
    public void barreVieFixe(int vie)
    {
        barreVie.value = vie;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un script compl�mentaire avec gestionViePersonnage. Celui-ci g�re la valeur du slider
 * afin d'avoir un visuel sur combien de d�g�ts le personnage prend.
 * Derni�re modification: 23 mars 2021
 ****************************************************************************************************/

public class barreDeVieScript : MonoBehaviour
{
    public Slider barreVie;

    // Reset la valeur maximale pour assurer qu'� chaque fois le personnage revient � sa vie maximale au lancement du jeu
    public void vieMax(int vie)
    {
        barreVie.maxValue = vie;
        barreVie.value = vie;
    }

    // Associer la valeur du slider � sa valeur de vie
    public void barreVieFixe(int vie)
    {
        barreVie.value = vie;
    }
}

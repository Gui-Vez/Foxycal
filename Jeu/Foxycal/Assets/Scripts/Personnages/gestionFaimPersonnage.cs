using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un script complémentaire avec barreDeFaimScript. Celui-ci gère la faim du personnage
 * Dernière modification: 23 mars 2021
 ****************************************************************************************************/

public class gestionFaimPersonnage : MonoBehaviour
{

    public float faimMax = 100;
    public static float faim;
    public barreDeFaimScript sliderFaim;
    public static bool mort;

    // On s'assure que lorsque le jeu est relancé, le personnage a toute sa vie
    void Start()
    {
        faim = faimMax;
        sliderFaim.faimMax(faimMax);
        mort = false;
    }

    // Le personnage perd de la faim par seconde, s'il a moins que 0, le personnage meurt, ne peut pas gagner plus que 100% de sa faim maximale
    void Update()
    {
        gestionFaim(1);

        if (faim <= 0)
        {
            mort = true;
        }

        if (faim > faimMax)
        {
            faim = faimMax;
        }
    }

    // Fonction qui met la perte de faim en marche en synchronisant avec le slider
    public void gestionFaim(float gestion)
    {
        faim -= gestion * Time.deltaTime;
        sliderFaim.barreFaimFixe(faim);
    }
}
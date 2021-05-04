using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*******************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un simple script pour simuler une faim réelle qui diminue à travers le temps
 * Dernière modification: 31 mars 2021
 ******************************************************************************************/

public class barreDeFaimScript : MonoBehaviour
{
    // Variable pour glisser le slider
    public Slider sliderFaim;

    // Gère la valeur de faim maximale avec son slider
    public void faimMax(float faim)
    {
        sliderFaim.maxValue = faim;
        sliderFaim.value = faim;
    }

    // Gère la valeur de faim avec le slider
    public void barreFaimFixe(float faim)
    {
        sliderFaim.value = faim;
    }

}

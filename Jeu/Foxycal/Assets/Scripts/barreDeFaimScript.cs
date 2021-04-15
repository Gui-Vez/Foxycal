using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*******************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un simple script pour simuler une faim r�elle qui diminue � travers le temps
 * Derni�re modification: 31 mars 2021
 ******************************************************************************************/

public class barreDeFaimScript : MonoBehaviour
{
    public Slider sliderFaim;

    public void faimMax(float faim)
    {
        sliderFaim.maxValue = faim;
        sliderFaim.value = faim;
    }

    public void barreFaimFixe(float faim)
    {
        sliderFaim.value = faim;
    }

}

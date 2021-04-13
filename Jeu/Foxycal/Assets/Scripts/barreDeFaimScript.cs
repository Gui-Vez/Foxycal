using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/******************************************************************************
 * Auteur: Andy
 * Derni�re modification: 31 mars 2021
 *****************************************************************************/

public class barreDeFaimScript : MonoBehaviour
{
    public Slider sliderFaim;

    public float faimMax = 100f;
    public float faim;

    // Reset la valeur de faim lors du lancement du jeu
    void Start()
    {
        faim = faimMax;
    }

    // Associer le slider avec la valeur de faim
    // Valeur diminue au fil du temps
    void Update()
    {
        sliderFaim.value = faim;
        faim -= 0.5f * Time.deltaTime;
    }
}

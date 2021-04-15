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
    public float faim;
    public barreDeFaimScript sliderFaim;

    // Start is called before the first frame update
    void Start()
    {
        faim = faimMax;
        sliderFaim.faimMax(faimMax);
    }

    // Update is called once per frame
    void Update()
    {
        gestionFaim(1);
    }

    public void gestionFaim(float gestion)
    {
        faim -= gestion * Time.deltaTime;
        sliderFaim.barreFaimFixe(faim);
    }
}
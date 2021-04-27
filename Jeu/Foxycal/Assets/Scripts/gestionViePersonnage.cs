using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*****************************************************************************************************
 * STATUS: En progr�s... � ajuster avec les petits renards qui attaquent le personnage (Health pack aussi?? Pt)
 * Auteur: Andy
 * Description: Un script compl�mentaire avec barreDeVieScript. Celui-ci g�re la vie maximale ainsi que le nombre de d�g�ts que le personnage prend
 * afin d'avoir un visuel sur combien de d�g�ts le personnage prend.
 * Derni�re modification: 23 mars 2021
 ****************************************************************************************************/

public class gestionViePersonnage : MonoBehaviour
{

    public int vieMax = 15;
    public int nbVie;
    public barreDeVieScript barreDeVie;
    // Start is called before the first frame update
    void Start()
    {
        nbVie = vieMax;
        barreDeVie.vieMax(vieMax);
    }

    void prendDegats(int degat)
    {
        nbVie -= degat;
        barreDeVie.barreVieFixe(nbVie);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ennemi" && CycleJour.tempsJournee == true)
        {
            prendDegats(1);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}

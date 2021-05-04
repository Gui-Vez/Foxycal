using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy et Jonathan
 * Description: Un script complémentaire avec barreDeVieScript. Celui-ci gère la vie maximale ainsi que le nombre de dégâts que le personnage prend
 * afin d'avoir un visuel sur combien de dégâts le personnage prend.
 * Dernière modification: 22 avril 2021
 ****************************************************************************************************/

public class gestionViePersonnage : MonoBehaviour
{
    // Variables du script
    public int vieMax = 15;
    public static int nbVie;
    public barreDeVieScript barreDeVie;

    // Start is called before the first frame update
    void Start()
    {
        nbVie = vieMax;
        barreDeVie.vieMax(vieMax);
    }

    // Si la vie du personnage tombe en bas de 0, il meurt, ne peut pas gagner plus que 100% de sa vie
    void Update()
    {
        if (nbVie <= 0)
        {
            gestionFaimPersonnage.mort = true;
        }

        if (nbVie > vieMax)
        {
            nbVie = vieMax;
        }
    }

    // Fonction pour contrôler le nombre de dégâts que le personnage prend et de l'afficher avec la barre du slider
    void prendDegats(int degat)
    {
        nbVie -= degat;
        barreDeVie.barreVieFixe(nbVie);
    }

    // Si le personnage se fait attaquer par un renard durant la nuit, il va prendre des dégâts
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

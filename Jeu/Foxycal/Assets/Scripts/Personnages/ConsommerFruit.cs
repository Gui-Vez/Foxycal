using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Script qui gère la consommation d'un fruit du personage
 * Dernière modification: 27 avril 2021
 ****************************************************************************************************/

public class ConsommerFruit : MonoBehaviour
{
    // Fonction qui fait en sorte que quand le joueur clique sur un fruit dans
    // l'inventaire, il gagne de la faim, détruit l'objet et joue un son
    public void consommerFruit()
    {
        GetComponent<Image>().enabled = false;
        Destroy(gameObject, 0.25f);
        gestionFaimPersonnage.faim += 10f;
        GetComponent<AudioSource>().Play();
    }
}

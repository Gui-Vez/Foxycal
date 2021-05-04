using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Script qui g�re chaque bo�te dans l'inventaire
 * Derni�re modification: 27 avril 2021
 ****************************************************************************************************/

public class Boite : MonoBehaviour
{
    // Variables pour ce script
    private GestionInventaire inventaire;
    public int i; // Chaque bo�te � sa propre valeur i

    // Trouver le script GestionInventaire associ� au personnage
    void Start()
    {
        inventaire = GameObject.FindGameObjectWithTag("Player").GetComponent<GestionInventaire>();
    }

    // Si on consomme ou on delete un fruit de l'inventaire, la bo�te sera � nouveau capable de
    // stocker un autre fruit 
    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventaire.rempli[i] = false;
        }
    }

    // Fonction qui fait en sorte que quand le joueur clique sur le bouton X dans l'inventaire,
    // le fruit dispara�t de l'inventaire
    public void TomberItem()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Script qui gère chaque boîte dans l'inventaire
 * Dernière modification: 27 avril 2021
 ****************************************************************************************************/

public class Boite : MonoBehaviour
{
    // Variables pour ce script
    private GestionInventaire inventaire;
    public int i; // Chaque boîte à sa propre valeur i

    // Trouver le script GestionInventaire associé au personnage
    void Start()
    {
        inventaire = GameObject.FindGameObjectWithTag("Player").GetComponent<GestionInventaire>();
    }

    // Si on consomme ou on delete un fruit de l'inventaire, la boîte sera à nouveau capable de
    // stocker un autre fruit 
    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventaire.rempli[i] = false;
        }
    }

    // Fonction qui fait en sorte que quand le joueur clique sur le bouton X dans l'inventaire,
    // le fruit disparaît de l'inventaire
    public void TomberItem()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}

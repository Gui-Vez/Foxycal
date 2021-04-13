using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasserObjet : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Script qui permet au renard de ramasser les objets

    private GestionInventaire inventaire;
    public GameObject fruit;

    void Start()
    {
        // Raccourci au script GestionInventaire
        inventaire = GameObject.FindGameObjectWithTag("Player").GetComponent<GestionInventaire>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Si le trigger est le joueur,
        if (other.CompareTag("Player"))
        {
            // En comptant chaque boite de l'inventaire,
            for (int i = 0; i < inventaire.boites.Length; i++)
            {
                // Si cette boite n'est pas remplie,
                if (inventaire.rempli[i] == false)
                {
                    // L'objet est rentré dans l'inventaire
                    inventaire.rempli[i] = true;

                    // Instancier le fruit dans l'inventaire
                    Instantiate(fruit, inventaire.boites[i].transform, false);

                    // Détruire l'objet
                    Destroy(gameObject);

                    // Arrêter la boucle
                    break;
                }
            }
        }
    }
}

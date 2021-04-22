using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasserFruit : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Script qui permet au renard de ramasser les fruits

    private GestionInventaire inventaire;
    public GameObject fruit;
    public GameObject Canvas;

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

                    // Augmenter le numéro de la quête
                    Canvas.GetComponent<GestionQuete>().AugmenterNumeroQuete(1);

                    // Augmenter le score
                    GestionScore.score++;

                    // Détruire l'objet
                    Destroy(gameObject);

                    // Arrêter la boucle
                    break;
                }
            }
        }
    }
}

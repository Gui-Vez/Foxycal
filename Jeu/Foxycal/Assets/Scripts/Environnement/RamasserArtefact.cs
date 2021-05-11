using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasserArtefact : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Script qui permet au renard de ramasser les atréfacts

    private GestionInventaire inventaire;
    public GameObject artefact;
    public GameObject Canvas;
    public GameObject portailActive;

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
                    Instantiate(artefact, inventaire.boites[i].transform, false);

                    // Augmenter le numéro de la quête
                    Canvas.GetComponent<GestionQuete>().AugmenterNumeroQuete(0);

                    // Augmenter le score
                    GestionScore.score++;

                    AudioSource audio = GetComponent<AudioSource>();
                    audio.Play();

                    // Détruire l'objet
                     GetComponent<Collider>().enabled = false;
                    Destroy(gameObject, 0.25f); //Ajoute un court délai à la destruction de l'objet pour jouer le son


                    // Arrêter la boucle
                    break;
                }
            }
        }
    }
}

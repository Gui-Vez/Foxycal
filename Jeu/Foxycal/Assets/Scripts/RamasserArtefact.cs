using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasserArtefact : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Script qui permet au renard de ramasser les atréfacts

    public GameObject Canvas;
    public GameObject portailActive;

    void OnTriggerEnter(Collider other)
    {
        // Si le trigger est le joueur,
        if (other.CompareTag("Player"))
        {
            // Augmenter le numéro de la quête
            Canvas.GetComponent<GestionQuete>().AugmenterNumeroQuete(0);

            // Détruire l'objet
            GetComponent<Collider>().enabled = false;
            Invoke("DetruireObjet", 0.25f); //Ajoute un court délai à la destruction de l'objet pour jouer le son

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
    public void DetruireObjet()
    {
        Destroy(gameObject);
    }
}

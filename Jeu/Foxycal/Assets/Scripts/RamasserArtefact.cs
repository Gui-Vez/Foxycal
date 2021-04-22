using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasserArtefact : MonoBehaviour
{
    /// Auteur : Guillaume V�zina
    /// Description : Script qui permet au renard de ramasser les atr�facts

    public GameObject Canvas;
    public GameObject portailActive;

    void OnTriggerEnter(Collider other)
    {
        // Si le trigger est le joueur,
        if (other.CompareTag("Player"))
        {
            // Augmenter le num�ro de la qu�te
            Canvas.GetComponent<GestionQuete>().AugmenterNumeroQuete(0);

            // D�truire l'objet
            Destroy(gameObject);
        }
    }
}

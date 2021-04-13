using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCiel : MonoBehaviour
{
    /// Auteur : Jonathan Rivest et Tristan Lapointe
    /// Description : Changer le ciel par rapport au temps de la journée

    public Material cielJour;
    public Material cielNuit;

    // Update is called once per frame
    void Update()
    {
        // Si le temps de la journée est mis à true,
        if (CycleJour.tempsJournee == true)
        {
            // Mettre le ciel de nuit
            RenderSettings.skybox = cielNuit;
        }

        // Sinon,
        else
        {
            // Mettre le ciel de jour
            RenderSettings.skybox = cielJour;
        }
    }
}

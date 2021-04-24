using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCiel : MonoBehaviour
{
    /// Auteur : Jonathan Rivest et Tristan Lapointe
    /// Description : Changer le ciel par rapport au temps de la journée

    public Material cielJour;
    public Material cielNuit;
    public GameObject lumiereJour;
    public GameObject lumiereNuit;
    public GameObject[] torches;

    // Update is called once per frame
    void Update()
    {
        // Si le temps de la journée est mis à true,
        if (CycleJour.tempsJournee == true)
        {
            // Mettre le ciel de nuit
            RenderSettings.skybox = cielNuit;
            RenderSettings.ambientIntensity = 0.25f;
            lumiereJour.GetComponent<Light>().color = new Color(207f/255f, 159f/255f, 245f/255f);
            lumiereJour.GetComponent<Light>().intensity = 0f;
            lumiereNuit.SetActive(true);
            foreach (GameObject torche in torches)
            {
                torche.SetActive(true);
            }
            

        }

        // Sinon,
        else
        {
            // Mettre le ciel de jour
            RenderSettings.skybox = cielJour;
            RenderSettings.ambientIntensity = 0.5f;
            lumiereJour.GetComponent<Light>().color = new Color(250f/255f, 255f/255f, 177f/255f);
            lumiereNuit.SetActive(false);
            lumiereJour.GetComponent<Light>().intensity = 1f;
            foreach (GameObject torche in torches)
            {
                torche.SetActive(false);
            }
        }
    }
}

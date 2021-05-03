using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneFin : MonoBehaviour
{
    
    public Material cielJour;
    public Material cielNuit;
    public GameObject lumiereJour;
    public GameObject lumiereNuit;
    public GameObject parcheminVictoire;
    public GameObject parcheminDefaite;
    public GameObject titreVictoire;
    public GameObject titreDefaite;
    // Start is called before the first frame update
    void Start()
    {
        if (GestionScore.score <= 3 || gestionFaimPersonnage.mort == true)
        {
            titreDefaite.SetActive(true);
            titreVictoire.SetActive(false);
            RenderSettings.skybox = cielNuit;
            lumiereNuit.SetActive(true);
            lumiereJour.GetComponent<Light>().color = new Color(207f / 255f, 159f / 255f, 245f / 255f);
            lumiereJour.GetComponent<Light>().intensity = 0f;
            parcheminDefaite.SetActive(true);

        }
        else
        {
            titreDefaite.SetActive(false);
            titreVictoire.SetActive(true);
            RenderSettings.skybox = cielJour;
            lumiereNuit.SetActive(false);
            lumiereJour.GetComponent<Light>().color = new Color(250f / 255f, 255f / 255f, 177f / 255f);
            lumiereJour.GetComponent<Light>().intensity = 1f;
            parcheminVictoire.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

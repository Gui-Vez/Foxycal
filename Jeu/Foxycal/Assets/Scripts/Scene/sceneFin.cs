using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneFin : MonoBehaviour
{
    /// Auteur : Jonathan Rivest
    /// Description : La scène de fin de jeu change en fonction du résultat de la partie
    public Material cielJour;
    public Material cielNuit;
    public GameObject lumiereJour;
    public GameObject lumiereNuit;
    public GameObject parcheminVictoire;
    public GameObject parcheminDefaite;
    public GameObject titreVictoire;
    public GameObject titreDefaite;
    public AudioClip sonVictoire;
    public AudioClip sonDefaite;
    public GameObject sourceAudio;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        if (GestionScore.score <= 3 || gestionFaimPersonnage.mort == true) // Si le joueur est mort ou a en bas de trois fruits...
        {
            titreDefaite.SetActive(true); // L'écran de défaite s'affiche.
            titreVictoire.SetActive(false);
            RenderSettings.skybox = cielNuit;
            lumiereNuit.SetActive(true);
            lumiereJour.GetComponent<Light>().color = new Color(207f / 255f, 159f / 255f, 245f / 255f);
            lumiereJour.GetComponent<Light>().intensity = 0f;
            parcheminDefaite.SetActive(true);
            sourceAudio.GetComponent<AudioSource>().PlayOneShot(sonDefaite);

        }
        else
        {
            titreDefaite.SetActive(false); // Sinon l'écran de victoire s'affiche.
            titreVictoire.SetActive(true);
            RenderSettings.skybox = cielJour;
            lumiereNuit.SetActive(false);
            lumiereJour.GetComponent<Light>().color = new Color(250f / 255f, 255f / 255f, 177f / 255f);
            lumiereJour.GetComponent<Light>().intensity = 1f;
            parcheminVictoire.SetActive(true);
            sourceAudio.GetComponent<AudioSource>().PlayOneShot(sonVictoire);
        }
    }

    
}

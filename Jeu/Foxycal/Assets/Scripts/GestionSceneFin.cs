using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionSceneFin : MonoBehaviour
{

    /// Auteur : Jonathan Rivest
    /// Description : G�re le chargement des sc�nes � partir de la sc�ne de fin.
    public void RecommencerJeu()
    {
        //Commencer le jeu
        
        SceneManager.LoadScene("Intro"); // Chargement du menu de d�but du jeu
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();  // Son au clic des boutons

    }

    public void QuitterJeu() // Arr�te le jeu
    {
        Application.Quit();
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

   
}

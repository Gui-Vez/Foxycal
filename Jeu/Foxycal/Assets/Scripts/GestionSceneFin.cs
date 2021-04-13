using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionSceneFin : MonoBehaviour
{

    /// Auteur : Jonathan Rivest
    /// Description : Gère le chargement des scènes à partir de la scène de fin.
    public void RecommencerJeu()
    {
        //Commencer le jeu
        
        SceneManager.LoadScene("Intro"); // Chargement du menu de début du jeu
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();  // Son au clic des boutons

    }

    public void QuitterJeu() // Arrête le jeu
    {
        Application.Quit();
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

   
}

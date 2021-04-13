using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestionScene : MonoBehaviour
{
    public GameObject Canvas;
    /// Auteur : Tristan Lapointe (Son int�gr� par Jonathan Rivest)
    /// Description : G�re les �v�nements au clic des boutons "Jouer" et "Quitter".

    public void ActiverJeu() //Pour d�buter le niveau un.
    {
        //Commencer le jeu
        SceneManager.LoadScene("Niveau1");
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

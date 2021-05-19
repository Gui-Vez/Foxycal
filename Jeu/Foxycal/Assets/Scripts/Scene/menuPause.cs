using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuPause : MonoBehaviour
{
    /// Auteur : Jonathan Rivest
    /// Description : Activation (et d�sactivation) du menu pause dans la sc�ne de jeu
    public static bool enPause = false;
    public GameObject leMenuPause;
    public GameObject cameraPause;
    public GameObject interfaceJoueur;
    public GameObject inventaire;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(enPause == false)
            {
                Pause();
            }
            else
            {
                Reprendre();
            }
        }
    }

    public void Reprendre()
    {
        Time.timeScale = 1f;
        leMenuPause.SetActive(false);
        enPause = false;
        cameraPause.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        interfaceJoueur.SetActive(true);
        inventaire.SetActive(true);
    }

    public void retourMenu() //Par le bouton "Quitter"
    {
        SceneManager.LoadScene("Intro");
        Time.timeScale = 1f;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        enPause = false;
        leMenuPause.SetActive(false);

    }

    void Pause()
    {
        Time.timeScale = 0f; // La sc�ne de jeu arr�te quand le jeu est en pause
        leMenuPause.SetActive(true);
        enPause = true;
        cameraPause.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        interfaceJoueur.SetActive(false); // Les autres interfaces du jeu sont enlev�es
        inventaire.SetActive(false);

    }


}

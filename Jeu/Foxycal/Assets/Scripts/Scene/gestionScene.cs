using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestionScene : MonoBehaviour
{
    public GameObject Canvas;
    public AudioClip SonPortail;
    public Animator transition;
    public float tempsTransition = 1f;
    public bool chargerFinFait = false;
    /// Auteur : Tristan Lapointe et Jonathan Rivest
    /// Description : Gère les évènements au clic des boutons "Jouer" et "Quitter", ainsi que les transitions de scène.


    public void Start()
    {
        
    }
    void Update()
    {
        if (chargerFinFait == false && Deplacement3ePerso.fin == true && GestionQuete.portailOuvert == true) //Charger la scène de fin
        {
            Invoke("ProchainNiveau", 4f);
            GestionQuete.portailOuvert = false;
            GetComponent<AudioSource>().PlayOneShot(SonPortail);
            
        }
    }

    public void RecommencerJeu() //Pour retourner à la scène d'intro
    {
        //Commencer le jeu
        SceneManager.LoadScene("Intro"); // Chargement du menu de début du jeu
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();  // Son au clic des boutons
    }

    public void ActiverJeu() //Pour débuter le niveau un.
    {
        //Commencer la coroutine qui appelle la fonction qui load la scène.
        StartCoroutine(ChargerNiveau(SceneManager.GetActiveScene().buildIndex + 1));
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();  // Son au clic des boutons
    }

    public void QuitterJeu() // Arrête le jeu
    {
        Application.Quit();
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play(); // Son au clic des boutons
    }

    public void ProchainNiveau()
    {
        chargerFinFait = true;
        Deplacement3ePerso.fin = false;
        StartCoroutine(ChargerNiveau(SceneManager.GetActiveScene().buildIndex + 1));
        Cursor.lockState = CursorLockMode.None;
    }

    IEnumerator ChargerNiveau(int indexNiveau) //Charge le prochain niveau, et fait la transition de scène
    {
        // Jouer l'animation
        transition.SetTrigger("Debut");

        // Attendre
        yield return new WaitForSeconds(tempsTransition);

        // Charger la scène
        SceneManager.LoadScene(indexNiveau);

        // print(SceneManager.GetActiveScene().buildIndex);
    }
}

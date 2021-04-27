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
    /// Description : G�re les �v�nements au clic des boutons "Jouer" et "Quitter", ainsi que les transitions de sc�ne.


    public void Start()
    {
        
    }
    void Update()
    {
        if (chargerFinFait == false && Deplacement3ePerso.fin == true && GestionQuete.portailOuvert == true) //Charger la sc�ne de fin
        {
            Invoke("ProchainNiveau", 4f);
            GestionQuete.portailOuvert = false;
            GetComponent<AudioSource>().PlayOneShot(SonPortail);
            
        }
    }

    public void RecommencerJeu() //Pour retourner � la sc�ne d'intro
    {
        //Commencer le jeu
        SceneManager.LoadScene("Intro"); // Chargement du menu de d�but du jeu
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();  // Son au clic des boutons
    }

    public void ActiverJeu() //Pour d�buter le niveau un.
    {
        //Commencer la coroutine qui appelle la fonction qui load la sc�ne.
        StartCoroutine(ChargerNiveau(SceneManager.GetActiveScene().buildIndex + 1));
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();  // Son au clic des boutons
    }

    public void QuitterJeu() // Arr�te le jeu
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

    IEnumerator ChargerNiveau(int indexNiveau) //Charge le prochain niveau, et fait la transition de sc�ne
    {
        // Jouer l'animation
        transition.SetTrigger("Debut");

        // Attendre
        yield return new WaitForSeconds(tempsTransition);

        // Charger la sc�ne
        SceneManager.LoadScene(indexNiveau);

        // print(SceneManager.GetActiveScene().buildIndex);
    }
}

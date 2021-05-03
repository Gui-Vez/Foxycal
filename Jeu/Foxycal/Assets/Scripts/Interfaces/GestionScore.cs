using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GestionScore : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Gère le pointage obtenu lors du jeu

    public GameObject GestionnaireScoreJeu;
    public static int score;
    public static bool dontDestroyFait;

    private void Start()
    {
        if (dontDestroyFait == false)
        {
            DontDestroyOnLoad(gameObject);
            //DontDestroyOnLoad(GestionnaireScoreJeu);
            dontDestroyFait = true;
        }
        else
        {
            Destroy(gameObject);
            //Destroy(GestionnaireScoreJeu);
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "sceneFin")
        {
            GestionnaireScoreJeu.GetComponent<Text>().text = score.ToString();
        }

    }
}
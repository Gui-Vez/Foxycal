using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionSceneFin : MonoBehaviour
{
    // Start is called before the first frame update
    public void RecommencerJeu()
    {
        //Commencer le jeu
        SceneManager.LoadScene("Intro");
    }

    public void QuitterJeu()
    {
        Application.Quit();
    }
}

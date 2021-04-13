using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestionScene : MonoBehaviour
{
    public GameObject Canvas;

    // Start is called before the first frame update
    public void ActiverJeu()
    {
        //Commencer le jeu
        SceneManager.LoadScene("Niveau1");
    }

    public void QuitterJeu()
    {
        Application.Quit();
    }
}

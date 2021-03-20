using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestionScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void ActiverJeu()
    {
        //Commencer le jeu
        SceneManager.LoadScene("Niveau1");
    }
}

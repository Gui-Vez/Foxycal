using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mortPerso : MonoBehaviour
{
    /// Auteur : Jonathan Rivest
    /// Description : Gère la mort du personnage et lance la scène de fin de partie
    // Update is called once per frame
    void Update()
    {
        if (gestionFaimPersonnage.mort == true)
        {
            GetComponent<Animator>().SetBool("EstMort", true);
            GetComponent<Animator>().SetBool("Marche", false);
            GetComponent<Animator>().SetBool("Mange", false);
            GetComponent<Animator>().SetBool("Saute", false);
            GetComponent<Animator>().SetBool("Pouvoir", false);
            GetComponent<Animator>().SetBool("Attaque", false);
            GetComponent<Animator>().SetBool("Attaque_L", false);
            GetComponent<Animator>().SetBool("Attaque_R", false);
            Invoke("chargementGameOver", 5f); 
        }
    }

    void desactivationAnimator()
    {
        GetComponent<Animator>().enabled = false;
    }
    void chargementGameOver()
    {
        SceneManager.LoadScene("sceneFin");
    }
}

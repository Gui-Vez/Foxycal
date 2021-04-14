using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accesSceneFin : MonoBehaviour
{
    /// Auteur : Jonathan Rivest
    /// Description : Acc�der � la fin par le portail magique

    
    // Collision des objets
    void OnCollisionEnter(Collision collision)
    {
        // Si le portail entre en contact avec le renard,
        if (collision.gameObject.name == "Fox Principal")
        {
            // Charger la sc�ne de fin
            Invoke("changementScene", 4f);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play(); //Son � l'activation du portail
            // Remettre le curseur � la normale
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void changementScene()
    {
        SceneManager.LoadScene("sceneFin");
    }
}

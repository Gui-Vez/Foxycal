using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy, Guillaume et Tristan
 * Description: Script qui gère l'apparition de d'une interface artéfact lorsque le personnage le touche
 * Dernière modification: 27 avril 2021
 ****************************************************************************************************/

public class ApparitionArtefactUI : MonoBehaviour
{
    // Les variables du script
    public GameObject[] interfaceArtefacts;
    public GameObject boutonFermer;
    private Collider objetArtefact;

    // Fonction qui détecte quand on touche un type d'artéfact
    void delaiTrigger()
    {
        switch (objetArtefact.gameObject.name)
        {
            case "Artefact1":
                interfaceArtefacts[0].SetActive(true);
                break;

            case "Artefact2":
                interfaceArtefacts[1].SetActive(true);
                break;

            case "Artefact3":
                interfaceArtefacts[0].SetActive(true);
                break;

            case "Artefact4":
                interfaceArtefacts[1].SetActive(true);
                break;

            case "Artefact5":
                interfaceArtefacts[0].SetActive(true);
                break;

            case "Artefact6":
                interfaceArtefacts[1].SetActive(true);
                break;
        }

        // Pour chaque artéfact contenant le tag Artefact, on active le bouton, le curseur et on met le jeu en pause
        if (objetArtefact.gameObject.tag == "Artefact")
        {

            boutonFermer.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
    }

    // Si on touche l'artéfact, une interface apparaîtra
    void OnTriggerEnter(Collider colliderArtefact)
    {
        objetArtefact = colliderArtefact;
        Invoke("delaiTrigger", 0.2f);
    }

    // Quand on clique le bouton X, on ferme l'interface au complet, on désactive le curseur, on remet le jeu en marche et on désactive chaque élément d'interface dans le tableau
    public void fermerInterface()
    {
        boutonFermer.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        foreach (GameObject Interface in interfaceArtefacts)
        {
            Interface.SetActive(false);
        }
    }
}


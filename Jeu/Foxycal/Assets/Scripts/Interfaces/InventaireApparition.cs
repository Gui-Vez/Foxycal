using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un simple script qui gère le UI de l'inventaire
 * Dernière modification: 15 avril 2021
 ****************************************************************************************************/
public class InventaireApparition : MonoBehaviour
{
    // Variables pour se script
    public GameObject inventaireMenu;
    public bool ouvert;

    // On commence le jeu avec l'inventaire fermé
    void Start()
    {
        inventaireMenu.SetActive(false);
    }

    // On ouvre l'inventaire avec la touche 'i'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (ouvert)
            {
                fermerInventaire();
            }

            else
            {
                ouvrirInventaire();
            }
        }
    }

    // Fonction qui gère l'apparition de l'inventaire
    // On active l'élément du canvas, on fait apparaître le curseur et on met le jeu en pause dans le fond
    public void ouvrirInventaire()
    {
        inventaireMenu.SetActive(true);
        ouvert = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }

    // Fonction qui gère la fermeture de l'inventaire
    // On désactive l'élément du canvas, enlève le curseur et on recommence le temps qui était en pause
    public void fermerInventaire()
    {
        inventaireMenu.SetActive(false);
        ouvert = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
}

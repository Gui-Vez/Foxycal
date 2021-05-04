using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un simple script qui g�re le UI de l'inventaire
 * Derni�re modification: 15 avril 2021
 ****************************************************************************************************/
public class InventaireApparition : MonoBehaviour
{
    // Variables pour se script
    public GameObject inventaireMenu;
    public bool ouvert;

    // On commence le jeu avec l'inventaire ferm�
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

    // Fonction qui g�re l'apparition de l'inventaire
    // On active l'�l�ment du canvas, on fait appara�tre le curseur et on met le jeu en pause dans le fond
    public void ouvrirInventaire()
    {
        inventaireMenu.SetActive(true);
        ouvert = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }

    // Fonction qui g�re la fermeture de l'inventaire
    // On d�sactive l'�l�ment du canvas, enl�ve le curseur et on recommence le temps qui �tait en pause
    public void fermerInventaire()
    {
        inventaireMenu.SetActive(false);
        ouvert = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un simple script qui gère le UI de l'inventaire
 * Dernière modification: 9 avril 2021
 ****************************************************************************************************/
public class InventaireApparition : MonoBehaviour
{
    public GameObject inventaireMenu;
    public bool ouvert;
    void Start()
    {
        inventaireMenu.SetActive(false);
    }

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

    public void ouvrirInventaire()
    {
        inventaireMenu.SetActive(true);
        ouvert = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }

    public void fermerInventaire()
    {
        inventaireMenu.SetActive(false);
        ouvert = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un simple script qui g�re le UI de l'inventaire
 * Derni�re modification: 9 avril 2021
 ****************************************************************************************************/
public class InventaireApparition : MonoBehaviour
{
    public bool visible = true;
    public GameObject Inventaire;

    // Si l'inventaire est visible, le rendre invisible avec la touche 'I' et vice-versa 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && visible == true)
        {
            Inventaire.SetActive(false);
            visible = false;
        }

        else if (Input.GetKeyDown(KeyCode.I) && visible == false)
        {
            Inventaire.SetActive(true);
            visible = true;
        }
    }
}

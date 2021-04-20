using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: En progrès... Quelques Bugs a regler
 * Auteur: Andy
 * Description: Script qui gère la consommation d'un fruit du personage
 * Dernière modification: 15 avril 2021
 ****************************************************************************************************/

public class ConsommerFruit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Boite>().detruireEnfant();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un simple script qui fait en sorte que la caméra suive le personnage
 * Dernière modification: 15 mars 2021
 ****************************************************************************************************/
public class miniCamScript : MonoBehaviour
{
    public Transform Personnage;

    // Attend que le personnage bouge en premier avant de update sa nouvelle position
    void LateUpdate()
    {
        Vector3 nouvellePosition = Personnage.position;
        nouvellePosition.y = transform.position.y;
        transform.position = nouvellePosition;
    }
}

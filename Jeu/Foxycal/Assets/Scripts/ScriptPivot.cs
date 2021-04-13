using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**********************************************************************************************************************************************
 * STATUS: En progrès... la caméra qui se rapproche ne marche pas trop trop, essayé les tests données par Vahik aussi sans succèes
 * Auteur: Andy
 * Description: Un script qui gère la position de la caméra comme dans Dark Souls 3 (Exception pour la bataille VS le dragon du Nameless King)
 * Dernière modification: 16 mars 2021
 *********************************************************************************************************************************************/

public class ScriptPivot : MonoBehaviour
{
    // Variables pour les differentes cameras
    public GameObject personnage;
    public GameObject cam3ePerso;
    public GameObject positionRayCastCam;

    // Variables changeables pour les distances
    public float hauteurPivot;
    public float distanceCamLoin;
    public float distanceCamProche = -0.5f;

    // Variable pour limiter le deplacement vertical de la camera
    public float rotationVert = 0f;

    // Gestion du déplacment de la caméra ainsi qu'un essai sur le rapprochement de la caméra si sa vue est obtruée
    void Update()
    {
        transform.position = personnage.transform.position + new Vector3(0, hauteurPivot, 0);
        transform.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);

        if (Physics.Raycast(positionRayCastCam.transform.position, positionRayCastCam.transform.forward, distanceCamLoin))
        {
            cam3ePerso.transform.localPosition = new Vector3(0, 1, distanceCamProche);
        }

        else
        {
            cam3ePerso.transform.localPosition = new Vector3(0, 0, distanceCamLoin);
        }
    }
}

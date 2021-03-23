using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniCamScript : MonoBehaviour
{
    public Transform Personnage;

    void LateUpdate()
    {
        Vector3 nouvellePosition = Personnage.position;
        nouvellePosition.y = transform.position.y;
        transform.position = nouvellePosition;
    }
}

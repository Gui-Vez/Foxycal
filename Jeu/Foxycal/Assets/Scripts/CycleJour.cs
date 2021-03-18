using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleJour : MonoBehaviour
{
    public Transform lumiere;
    public int vitesseRotation;

    void Update()
    {
        lumiere.Rotate(vitesseRotation * Time.deltaTime, 0, 0);
        if(lumiere.eulerAngles.x > 179)
        {
            vitesseRotation = 25;
        }
        else
        {
            vitesseRotation = 50;
        }
    }
}

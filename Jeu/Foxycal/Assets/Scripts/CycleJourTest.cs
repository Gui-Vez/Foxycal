using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleJourTest : MonoBehaviour
{
    public Transform lumiere;
    public int vitesseRotation;
    public static bool tempsJournee;

    void Start()
    {
        cycleVitesse();
    }

    void Update()
    {
        lumiere.Rotate(vitesseRotation * Time.deltaTime, 0, 0);
        if (lumiere.eulerAngles.x > 179)
        {
            tempsJournee = true;
        }
        else
        {
            tempsJournee = false;
        }
    }

    void cycleVitesse()
    {
       vitesseRotation = Random.Range(10, 50);
    }
}

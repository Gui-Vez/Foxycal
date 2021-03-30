using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CycleJour : MonoBehaviour
{
    public Transform lumiere;
    public int vitesseRotation;
    public static bool tempsJournee;
    public Slider slider;

    void Update()
    {
        vitesseRotation = 17;
        lumiere.Rotate(vitesseRotation * Time.deltaTime, 0, 0);
        if(lumiere.eulerAngles.x > 179)
        {
            tempsJournee = true;
            slider.value -= 0.002f;

        }
        else
        {
            tempsJournee = false;
            slider.value += 0.002f;
        }
    }

}

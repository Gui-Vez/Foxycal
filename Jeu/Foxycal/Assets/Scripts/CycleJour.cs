using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CycleJour : MonoBehaviour
{
    public Transform lumiere;
    public int vitesseRotation;
    public static bool tempsJournee; // Bool statique indiquant le temps de la journée aux scripts.
    public Slider slider; //Slider indiquant le temps restant avant que le jour ou la nuit arrive.

    void Update()
    {
        vitesseRotation = 15; // La vitesse à laquelle la lumière principale du niveau tourne.
        lumiere.Rotate(vitesseRotation * Time.deltaTime, 0, 0);
        if(lumiere.eulerAngles.x > 179) // Si la rotation de la lumière atteint cette valeur, la nuit est tombée.
        {
            tempsJournee = true; // True = la nuit est tombée.
            slider.value -= 0.0009f; // La vitesse du slider.

        }
        else
        {
            tempsJournee = false; // False = c'est le jour.
            slider.value += 0.0009f;
        }
    }

}

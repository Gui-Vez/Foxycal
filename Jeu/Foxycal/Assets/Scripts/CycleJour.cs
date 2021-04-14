using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CycleJour : MonoBehaviour
{
    /// Auteur : Jonathan Rivest
    /// Description : R�gler le cycle du jour et de la nuit

    public Transform lumiere;
    public int vitesseRotation;
    public static bool tempsJournee; // Bool statique indiquant le temps de la journ�e aux scripts.
    public Slider slider; //Slider indiquant le temps restant avant que le jour ou la nuit arrive.
    public float vitesseSlider; //Indique la vitesse du slider (manuelle)
    public GameObject sonNuit; // Permet d'activer le son se trouvant dans son audio source.

    void Start()
    {
        tempsJournee = false;
    }

    void Update()
    {
        vitesseRotation = 15; // La vitesse � laquelle la lumi�re principale du niveau tourne.
        lumiere.Rotate(vitesseRotation * Time.deltaTime, 0, 0);
        if(lumiere.eulerAngles.x > 179) // Si la rotation de la lumi�re atteint cette valeur, la nuit est tomb�e.
        {
            tempsJournee = true; // True = la nuit est tomb�e.
            slider.value -= vitesseSlider; // La vitesse du slider.
            sonNuit.SetActive(true); // Active le son une seule fois la nuit.
            

        }
        else
        {
            tempsJournee = false; // False = c'est le jour.
            slider.value += vitesseSlider;
            sonNuit.SetActive(false);
        }
    }

}

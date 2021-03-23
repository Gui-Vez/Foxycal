using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barreDeVieScript : MonoBehaviour
{
    public Slider barreVie;


    public void vieMax(int vie)
    {
        barreVie.maxValue = vie;
        barreVie.value = vie;
    }
    public void barreVieFixe(int vie)
    {
        barreVie.value = vie;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class controleAudio : MonoBehaviour
{
    public AudioMixer niveauSon;
    public Slider slider;
    public float valeurSlider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("save", valeurSlider);

    }

    public void commandeAudio(float audio)
    {
        niveauSon.SetFloat("niveauAudio", audio);
    }

    public void maintenirValeur(float valeur)
    {
        valeurSlider = valeur;
        PlayerPrefs.SetFloat("save", valeurSlider);
    }
}

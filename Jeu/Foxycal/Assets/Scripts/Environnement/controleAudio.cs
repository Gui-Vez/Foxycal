using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class controleAudio : MonoBehaviour
{
    /// Auteur : Jonathan Rivest
    /// Description : Synchronise la valeur du slider au niveau de l'audio
    public AudioMixer niveauSon;
    public Slider slider;
    public float valeurSlider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("save", valeurSlider); // Reconnait la valeur de l'audio précédemment établie par le joueur

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

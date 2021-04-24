using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menuPause : MonoBehaviour
{
    public static bool enPause = false;
    public GameObject leMenuPause;
    public GameObject lePivot;
    public GameObject cameraPause;
    public AudioMixer niveauSon;
    public Slider slider;
    public float valeurSlider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("save", valeurSlider);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(enPause == false)
            {
                Pause();
            }
            else
            {
                Reprendre();
            }
        }
    }

    public void Reprendre()
    {
        Time.timeScale = 1f;
        leMenuPause.SetActive(false);
        enPause = false;
        lePivot.SetActive(true);
        cameraPause.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    public void retourMenu()
    {
        SceneManager.LoadScene("Intro");
        Time.timeScale = 1f;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        enPause = false;
        leMenuPause.SetActive(false);
    }

    void Pause()
    {
        Time.timeScale = 0f;
        leMenuPause.SetActive(true);
        enPause = true;
        lePivot.SetActive(false);
        cameraPause.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    public void controleAudio(float audio)
    {
        niveauSon.SetFloat("niveauAudio", audio);
    }

    public void maintenirValeur(float valeur)
    {
        valeurSlider = valeur;
        PlayerPrefs.SetFloat("save", valeurSlider);
    }
}

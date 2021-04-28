using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menuPause : MonoBehaviour
{
    public static bool enPause = false;
    public GameObject leMenuPause;
    public GameObject cameraPause;
    public GameObject interfaceJoueur;
    public GameObject inventaire;

    // Start is called before the first frame update
    void Start()
    {
        
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
        cameraPause.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        interfaceJoueur.SetActive(true);
        inventaire.SetActive(true);
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
        cameraPause.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        interfaceJoueur.SetActive(false);
        inventaire.SetActive(false);

    }


}

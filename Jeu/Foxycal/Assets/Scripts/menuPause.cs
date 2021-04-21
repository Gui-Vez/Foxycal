using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class menuPause : MonoBehaviour
{
    public static bool enPause = false;
    public GameObject leMenuPause;
    public GameObject lePivot;
    public GameObject cameraPause;
    public AudioMixer niveauSon;
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
        lePivot.SetActive(true);
        cameraPause.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
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
}

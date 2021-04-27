using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAudioMenus : MonoBehaviour
{
    public static bool enPause = false;
    public GameObject interfaceMenu;
    public GameObject menuPause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (enPause == false)
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
        menuPause.SetActive(false);
        interfaceMenu.SetActive(true);
        enPause = false; 
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    void Pause()
    {
        menuPause.SetActive(true);
        interfaceMenu.SetActive(false);
        enPause = true;
    }
}

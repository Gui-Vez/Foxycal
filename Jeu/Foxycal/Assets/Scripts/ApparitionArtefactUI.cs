using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparitionArtefactUI : MonoBehaviour
{

    public GameObject[] interfaceArtefacts;
    public GameObject boutonFermer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider colliderArtefact)
    {
        switch (colliderArtefact.gameObject.name)
        {
            case "Artefact1":
                interfaceArtefacts[0].SetActive(true);
                break;

            case "Artefact2":
                interfaceArtefacts[1].SetActive(true);
                break;

            default:
                Debug.Log("ceci est un artefact");
                break;
        }

        if (colliderArtefact.gameObject.tag == "Artefact")
        {
            boutonFermer.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            print("taken");
        }
    }

    public void fermerInterface()
    {
        boutonFermer.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        foreach (GameObject Interface in interfaceArtefacts)
        {
            Interface.SetActive(false);
        }
    }
}


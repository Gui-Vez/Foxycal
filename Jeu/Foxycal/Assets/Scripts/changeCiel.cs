using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCiel : MonoBehaviour
{

    public Material cielJour;
    public Material cielNuit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(RenderSettings.skybox);
        if (CycleJour.tempsJournee == true)
        {
            RenderSettings.skybox = cielNuit;
        }
        else
        {
            RenderSettings.skybox = cielJour;
        }
    }
}

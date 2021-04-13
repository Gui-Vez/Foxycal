using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestionViePersonnage : MonoBehaviour
{

    public int vieMax = 15;
    public int nbVie;
    public barreDeVieScript barreDeVie;
    // Start is called before the first frame update
    void Start()
    {
        nbVie = vieMax;
        barreDeVie.vieMax(vieMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            prendDegats(5);
        }
    }

    void prendDegats(int degat)
    {
        nbVie -= degat;
        barreDeVie.barreVieFixe(nbVie);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Un simple script qui garde le score entre les sc�nes
 * Derni�re modification: 2 mai 2021
 ****************************************************************************************************/

public class garderScore : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
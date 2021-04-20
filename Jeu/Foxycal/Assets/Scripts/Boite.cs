using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boite : MonoBehaviour
{
    public void detruireEnfant()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionFeuTorches : MonoBehaviour
{
    public List<GameObject> GrandesTorches;

    // Start is called before the first frame update
    void Start()
    {
        // Pour chaque enfant du gameobject,
        for (int i = 0; i < transform.childCount; i++)
        {
            // Ajouter les grandes torches dans une liste
            GrandesTorches.Add(transform.GetChild(i).gameObject);
        }
    }

    public void GererFlames(bool val)
    {
        // Pour chacune des torches,
        foreach (GameObject GrandeTorche in GrandesTorches)
        {
            // Activer / Désactiver la flame
            GrandeTorche.transform.GetChild(0).gameObject.SetActive(val);
        }
    }
}

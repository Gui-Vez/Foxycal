using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renardMagique : MonoBehaviour
{
    public Transform lumiere;
    public GameObject magieRenard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CycleJour.tempsJournee == true)
        {
            SkinnedMeshRenderer mesh = magieRenard.GetComponent<SkinnedMeshRenderer>();
            mesh.enabled = true;
        }
        else
        {
            SkinnedMeshRenderer mesh = magieRenard.GetComponent<SkinnedMeshRenderer>();
            mesh.enabled = false;
        }
    }
}

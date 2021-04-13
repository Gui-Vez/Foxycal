using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renardMagique : MonoBehaviour
{
    
    public GameObject magieRenard; // Pour placer un mesh renderer se trouvant dans un game object enfant.
    
    // Update is called once per frame
    void Update()
    {
        if (CycleJour.tempsJournee == true)
        {
            SkinnedMeshRenderer mesh = magieRenard.GetComponent<SkinnedMeshRenderer>();
            mesh.enabled = true; // Le mesh renderer magique s'active la nuit.
        }
        else
        {
            SkinnedMeshRenderer mesh = magieRenard.GetComponent<SkinnedMeshRenderer>();
            mesh.enabled = false; // Le mesh renderer n'est pas activé le jour.
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventaireApparition : MonoBehaviour
{
    public bool visible = true;
    public GameObject Inventaire;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && visible == true)
        {
            Inventaire.SetActive(false);
            visible = false;
        }

        else if (Input.GetKeyDown(KeyCode.I) && visible == false)
        {
            Inventaire.SetActive(true);
            visible = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPouvoirs : MonoBehaviour
{
    public GameObject RefPouvoirE;
    public GameObject RefPouvoirR;
    public GameObject RefPouvoirT;

    private GameObject ClonePouvoirE;
    private GameObject ClonePouvoirR;
    private GameObject ClonePouvoirT;

    public void LancerPouvoir(string Pouvoir)
    {
        switch (Pouvoir)
        {
            case "E":

                ClonePouvoirE = Instantiate(RefPouvoirE);

                ClonePouvoirE.transform.parent = RefPouvoirE.transform.parent;

                ClonePouvoirE.transform.position = RefPouvoirE.transform.position;

                ClonePouvoirE.name = "Foudre Mystique";

                ClonePouvoirE.SetActive(true);

                break;


            case "R":

                ClonePouvoirR = Instantiate(RefPouvoirR);

                ClonePouvoirR.transform.parent = RefPouvoirR.transform.parent;

                ClonePouvoirR.transform.position = RefPouvoirR.transform.position;

                ClonePouvoirR.name = "Appel du Ciel";

                ClonePouvoirR.SetActive(true);

                break;


            case "T":

                ClonePouvoirT = Instantiate(RefPouvoirT);

                ClonePouvoirT.transform.parent = RefPouvoirT.transform.parent;

                ClonePouvoirT.transform.position = RefPouvoirT.transform.position;

                ClonePouvoirT.name = "Souffle Électrique";

                ClonePouvoirT.SetActive(true);

                break;
        }
    }
}

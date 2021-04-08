using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPouvoirs : MonoBehaviour
{
    public GameObject RefPouvoirE;
    public GameObject RefPouvoirR;
    public GameObject RefPouvoirT;
    public GameObject RefComete;

    private GameObject ClonePouvoirE;
    private GameObject ClonePouvoirR;
    private GameObject ClonePouvoirT;
    private GameObject CloneComete;

    public float vitessePouvoirT;
    public float dureePouvoirT;

    public IEnumerator LancerPouvoir(string Pouvoir)
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

                CloneComete = Instantiate(RefComete);

                CloneComete.transform.parent = RefComete.transform.parent;

                CloneComete.transform.position = RefComete.transform.position;

                CloneComete.name = "Comete";

                CloneComete.SetActive(true);

                Destroy(CloneComete, 1);

                yield return new WaitForSeconds(1);

                ClonePouvoirR = Instantiate(RefPouvoirR);

                ClonePouvoirR.transform.parent = null;

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

                ClonePouvoirT.GetComponent<Rigidbody>().velocity = (transform.forward * vitessePouvoirT);

                ClonePouvoirT.transform.parent = null;

                Destroy(ClonePouvoirT, dureePouvoirT);

                break;
        }

        yield return null;
    }
}

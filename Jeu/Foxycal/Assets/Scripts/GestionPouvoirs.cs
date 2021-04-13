using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPouvoirs : MonoBehaviour
{
    /// Auteur : Guillaume V�zina
    /// Description : Active les pouvoirs du personnage

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
        // Selon le pouvoir,
        switch (Pouvoir)
        {
            case "E":

                // Faire un clone � ce pouvoir
                ClonePouvoirE = Instantiate(RefPouvoirE);

                // Changer le parent du pouvoir
                ClonePouvoirE.transform.parent = RefPouvoirE.transform.parent;

                // R��tablir la position du pouvoir
                ClonePouvoirE.transform.position = RefPouvoirE.transform.position;

                // Changer le nom du clone
                ClonePouvoirE.name = "Foudre Mystique";

                // Activer le clone
                ClonePouvoirE.SetActive(true);

                break;


            case "R":

                // Faire un clone � la comete
                CloneComete = Instantiate(RefComete);

                // Changer le parent de la comete
                CloneComete.transform.parent = RefComete.transform.parent;

                // R��tablir la position de la comete
                CloneComete.transform.position = RefComete.transform.position;

                // Changer le nom du clone
                CloneComete.name = "Comete";

                // Activer le clone
                CloneComete.SetActive(true);

                // D�truire l'objet apr�s 1 seconde
                Destroy(CloneComete, 1);


                // Attendre une seconde
                yield return new WaitForSeconds(1);


                // Faire un clone � ce pouvoir
                ClonePouvoirR = Instantiate(RefPouvoirR);

                // Changer le parent du pouvoir
                ClonePouvoirR.transform.parent = null;

                // R��tablir la position du pouvoir
                ClonePouvoirR.transform.position = RefPouvoirR.transform.position;

                // Changer le nom du clone
                ClonePouvoirR.name = "Appel du Ciel";

                // Activer le clone
                ClonePouvoirR.SetActive(true);

                break;


            case "T":

                // Faire un clone � ce pouvoir
                ClonePouvoirT = Instantiate(RefPouvoirT);

                // Changer le parent du pouvoir
                ClonePouvoirT.transform.parent = RefPouvoirT.transform.parent;

                // R��tablir la position du pouvoir
                ClonePouvoirT.transform.position = RefPouvoirT.transform.position;

                // Changer le nom du clone
                ClonePouvoirT.name = "Souffle �lectrique";

                // Activer le clone
                ClonePouvoirT.SetActive(true);

                // Appliquer une v�locit� pour le pouvoir
                ClonePouvoirT.GetComponent<Rigidbody>().velocity = (transform.forward * vitessePouvoirT);

                // Retirer le parent du clone
                ClonePouvoirT.transform.parent = null;

                // D�truire le clone apr�s un certain temps
                Destroy(ClonePouvoirT, dureePouvoirT);

                break;
        }

        yield return null;
    }
}

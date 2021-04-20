using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionPouvoirs : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Active les pouvoirs du personnage

    public GameObject RefPouvoirLMC;
    public GameObject RefPouvoirE;
    public GameObject RefPouvoirT;
    public GameObject RefComete;

    private GameObject ClonePouvoirLMC;
    private GameObject ClonePouvoirE;
    private GameObject ClonePouvoirT;
    private GameObject CloneComete;

    public float vitessePouvoirT;
    public float dureePouvoirT;

    public Image FondPouvoir1;
    public Image FondPouvoir2;
    public Image FondPouvoir3;

    public float TempsPouvoir1 = 5;
    public float TempsPouvoir2 = 8;
    public float TempsPouvoir3 = 13;


    void Start()
    {
        // Remettre la valeur du fond à 0 pour le rendre vide
        FondPouvoir1.fillAmount = 0;
        FondPouvoir2.fillAmount = 0;
        FondPouvoir3.fillAmount = 0;
    }

    void Update()
    {
        FondPouvoir3.fillAmount += 0.01f;
    }

    public IEnumerator LancerPouvoir(string Pouvoir)
    {
        // Selon le pouvoir,
        switch (Pouvoir)
        {
            case "LMC":

                // Faire un clone à ce pouvoir
                ClonePouvoirLMC = Instantiate(RefPouvoirLMC);

                // Changer le parent du pouvoir
                ClonePouvoirLMC.transform.parent = RefPouvoirLMC.transform.parent;

                // Réétablir la position du pouvoir
                ClonePouvoirLMC.transform.position = RefPouvoirLMC.transform.position;

                // Changer le nom du clone
                ClonePouvoirLMC.name = "Morsure";

                // Activer le clone
                ClonePouvoirLMC.SetActive(true);

                // Détruire l'objet après 1 seconde
                Destroy(ClonePouvoirLMC, 1f);

                break;


            case "E":

                // Faire un clone à ce pouvoir
                ClonePouvoirE = Instantiate(RefPouvoirE);

                // Changer le parent du pouvoir
                ClonePouvoirE.transform.parent = RefPouvoirE.transform.parent;

                // Réétablir la position du pouvoir
                ClonePouvoirE.transform.position = RefPouvoirE.transform.position;

                // Changer le nom du clone
                ClonePouvoirE.name = "Foudre Mystique";

                // Activer le clone
                ClonePouvoirE.SetActive(true);

                break;


            case "R":

                // Faire un clone à la comete
                CloneComete = Instantiate(RefComete);

                // Changer le parent de la comete
                CloneComete.transform.parent = RefComete.transform.parent;

                // Réétablir la position de la comete
                CloneComete.transform.position = RefComete.transform.position;

                // Changer le nom du clone
                CloneComete.name = "Comete";

                // Activer le clone
                CloneComete.SetActive(true);

                break;


            case "T":

                // Faire un clone à ce pouvoir
                ClonePouvoirT = Instantiate(RefPouvoirT);

                // Changer le parent du pouvoir
                ClonePouvoirT.transform.parent = RefPouvoirT.transform.parent;

                // Réétablir la position du pouvoir
                ClonePouvoirT.transform.position = RefPouvoirT.transform.position;

                // Changer le nom du clone
                ClonePouvoirT.name = "Souffle Électrique";

                // Activer le clone
                ClonePouvoirT.SetActive(true);

                // Appliquer une vélocité pour le pouvoir
                ClonePouvoirT.GetComponent<Rigidbody>().velocity = (transform.forward * vitessePouvoirT);

                // Retirer le parent du clone
                ClonePouvoirT.transform.parent = null;

                // Détruire le clone après un certain temps
                Destroy(ClonePouvoirT, dureePouvoirT);

                break;
        }

        yield return null;
    }
}

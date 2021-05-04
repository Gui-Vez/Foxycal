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

    public Sprite SpritePouvoir1;
    public Sprite SpritePouvoir2;
    public Sprite SpritePouvoir3;
    public Sprite SpritePouvoirIndisponible;

    public Image ImagePouvoir1;
    public Image ImagePouvoir2;
    public Image ImagePouvoir3;

    public static float TempsPouvoir1;
    public static float TempsPouvoir2;
    public static float TempsPouvoir3;


    void Start()
    {
        

        // Remettre la valeur des fonds à 0 pour les rendre vides
        FondPouvoir1.fillAmount = 0;
        FondPouvoir2.fillAmount = 0;
        FondPouvoir3.fillAmount = 0;
    }

    public void ViderPouvoir(int pouvoir)
    {
        switch (pouvoir)
        {
            // Rendre les fonds opaques
            case 1: FondPouvoir1.fillAmount = 1; break;
            case 2: FondPouvoir2.fillAmount = 1; break;
            case 3: FondPouvoir3.fillAmount = 1; break;
        }
    }

    void Update()
    {
        // Régler le temps des animations
        TempsPouvoir1 = GestionAnimations.TempsE + 1;
        TempsPouvoir2 = GestionAnimations.TempsR + 1;
        TempsPouvoir3 = GestionAnimations.TempsT + 1;
        // Enlever le fond progressivement par rapport au temps énoncé
        FondPouvoir1.fillAmount -= 1 / TempsPouvoir1 * Time.deltaTime;
        FondPouvoir2.fillAmount -= 1 / TempsPouvoir2 * Time.deltaTime;
        FondPouvoir3.fillAmount -= 1 / TempsPouvoir3 * Time.deltaTime;

        // Si le fond est enlevé et que c'est la nuit,
        if (CycleJour.tempsJournee)
        {
            // Afficher les pouvoirs disponibles
            if (FondPouvoir1.fillAmount == 0)
                ImagePouvoir1.sprite = SpritePouvoir1;

            if (FondPouvoir2.fillAmount == 0)
                ImagePouvoir2.sprite = SpritePouvoir2;

            if (FondPouvoir3.fillAmount == 0)
                ImagePouvoir3.sprite = SpritePouvoir3;
        }

        // Sinon,
        else
        {
            // Afficher les pouvoirs indisponibles
            ImagePouvoir1.sprite = SpritePouvoirIndisponible;
            ImagePouvoir2.sprite = SpritePouvoirIndisponible;
            ImagePouvoir3.sprite = SpritePouvoirIndisponible;
        }
    }

    public IEnumerator LancerPouvoir(string Pouvoir)
    {
        if (menuPause.enPause == false)
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
}

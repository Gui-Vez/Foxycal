using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMeteorite : MonoBehaviour
{
    public GameObject RefPouvoirR;
    private GameObject ClonePouvoirR;


    void OnCollisionEnter(Collision collision)
    {
        // Faire un clone à ce pouvoir
        ClonePouvoirR = Instantiate(RefPouvoirR);

        // Changer le parent de la comete
        ClonePouvoirR.transform.parent = RefPouvoirR.transform.parent;

        // Réétablir la position du pouvoir
        ClonePouvoirR.transform.position = gameObject.transform.position;

        // Changer le nom du clone
        ClonePouvoirR.name = "Appel du Ciel";

        // Activer le clone
        ClonePouvoirR.SetActive(true);

        // Détruire l'objet
        Destroy(gameObject);
    }
}

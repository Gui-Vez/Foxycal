using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CollisionPouvoir : MonoBehaviour
{
    /// Auteur : Guillaume V�zina
    /// Description : G�re la collision des pouvoirs avec les ennemis

    GameObject RefEnnemi;
    public int pointDeVie;
    

    // Au commencement,
    void Start()
    {
        // R�f�rencer l'ennemi � l'objet qui d�tient le script
        RefEnnemi = gameObject;

        // Donner deux points de vie
        pointDeVie = 2;
    }

    // Lors d'une collision,
    void OnTriggerEnter(Collider other)
    {
        // Si l'ennemi entre en collision avec un pouvoir,
        if (other.CompareTag("Pouvoir"))
        {
            // Diminuer la vie
            DiminuerVie();

            // Jouer l'animation d'�tre attaqu�
            GetComponent<Animator>().SetTrigger("estAttaqu�");
        }
    }

    void DiminuerVie()
    {
        // Diminuer le point de vie
        pointDeVie--;

        // S'il ne reste plus de point de vie,
        if (pointDeVie == 0)
        {
            // Jouer l'animation de mort
            GetComponent<Animator>().SetTrigger("mort");

            // Enlever le set destination
            GetComponent<NavMeshAgent>().isStopped = true;

            // Enlever l'ennemi apr�s un d�lai
            Invoke("EnleverEnnemi", 2.5f);
        }
    }

    void EnleverEnnemi()
    {
        // D�truire l'objet
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CollisionAttaque : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Gère la collision des pouvoirs avec les ennemis

    GameObject RefEnnemi;
    public int pointDeVie;
    

    // Au commencement,
    void Start()
    {
        // Référencer l'ennemi à l'objet qui détient le script
        RefEnnemi = gameObject;

        // Donner deux points de vie
        pointDeVie = 3;
    }

    // Lors d'une collision,
    void OnTriggerEnter(Collider other)
    {
        // Si l'ennemi entre en collision avec un pouvoir,
        if (other.CompareTag("Pouvoir"))
        {
            if (other.name == "Souffle Électrique" || other.name == "Foudre Mystique" || other.name == "Appel du Ciel")
            {
                // Diminuer la vie
                DiminuerVie(3);
            }

            // Jouer l'animation d'être attaqué
            GetComponent<Animator>().SetTrigger("estAttaqué");
        }
    }
    
    void DiminuerVie(int degat)
    {
        // Diminuer le point de vie
        pointDeVie -= degat;

        // S'il ne reste plus de point de vie,
        if (pointDeVie <= 0)
        {
            // Jouer l'animation de mort
            GetComponent<Animator>().SetTrigger("mort");

            // Enlever le set destination
            GetComponent<NavMeshAgent>().isStopped = true;


            // Incrémenter le score
            GestionScore.score++;

            // Enlever l'ennemi après un délai
            Invoke("EnleverEnnemi", 2.5f);
        }
    }

    void EnleverEnnemi()
    {
        // Détruire l'objet
        Destroy(gameObject);
    }
    
}

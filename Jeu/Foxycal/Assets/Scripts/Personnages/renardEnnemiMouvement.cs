using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class renardEnnemiMouvement : MonoBehaviour
{
    /// Auteur : Jonathan Rivest (Commentaires par Guillaume)
    /// Description : Situer la direction que doit prendre l'ennemi


    // L'objet vers où les renards se déplacent
    public GameObject cibleRenard;

    NavMeshAgent navAgent;
    public bool test;
    public AudioClip attaqueSubite;
    AudioSource sourceAudio;

    // Au début,
    void Start()
    {
        // Raccourcir la variable du NavMeshAgent
        navAgent = GetComponent<NavMeshAgent>();

        // Chercher un arbre
        chercheArbre();
    }

    // À chaque frame,
    void Update()
    {
        // Activer le NavMeshAgent
        navAgent.enabled = true;


        if (CycleJour.tempsJournee == true)
        {
            // Capter la position actuelle du joueur
            navAgent.SetDestination(cibleRenard.transform.position);

            // Désactiver la variable de test (?)
            test = false;
        }

        else if(CycleJour.tempsJournee == false && test == false )
        {
            // Activer la variable de test (?)
            test = true;

            // Chercher un arbre
            chercheArbre();
        }
        if(gestionFaimPersonnage.mort == true)
        {
            navAgent.enabled = false;
        }
    }

    void chercheArbre() 
    {
        // Chercher tous les arbres du niveau
        GameObject[] arbres = GameObject.FindGameObjectsWithTag("arbre");

        // Sélectioner l'un des arbres
        int indexArbres = Random.Range(0, arbres.Length);

        // S'il y a des arbres,
        if (arbres.Length != 0)
        {
            // Déplacer le renard à cet arbre
            navAgent.SetDestination(arbres[indexArbres].transform.position);
        }
    }

    // Lors d'une collision,
    void OnCollisionEnter (Collision collision)
    {
        // Si la collision est le Fox Principal ET que c'est la nuit,
        if (collision.gameObject.name == "Fox Principal" && CycleJour.tempsJournee == true)
        {
            if(GestionAnimations.attaque == false) //si le joueur n'attaque pas..
            {
                // Activer l'animation d'attaque
                GetComponent<Animator>().SetTrigger("attaque"); // L'ennemi attaque
            }
            else
            {
                // Activer l'animation d'attaque
                GetComponent<Animator>().SetTrigger("estAttaqué");
                navAgent.enabled = false;
                navAgent.speed = 0f;
                GetComponent<AudioSource>().PlayOneShot(attaqueSubite, 1f);
                Invoke("reactiveAgent", 1f);
            }

        }

        // Si la collision est un arbre,
        if (collision.gameObject.tag == "arbre")
        {
            // Chercher un autre arbre
            chercheArbre();
        }
    }

    void reactiveAgent()
    {
        navAgent.enabled = true;
        navAgent.speed = 2f;
    }
}

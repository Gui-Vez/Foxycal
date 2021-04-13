using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class renardEnnemiMouvement : MonoBehaviour
{
    public GameObject cibleRenard; // L'objet vers où les renards se déplacent

    NavMeshAgent navAgent;
    public bool test;

    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();

        chercheArbre();

    }

    // Update is called once per frame
    void Update()
    {
        navAgent.enabled = true;

        

        if (CycleJour.tempsJournee == true)
        {
            navAgent.SetDestination(cibleRenard.transform.position); //Capte la position actuelle du joueur
            test = false;


        }
        else if(CycleJour.tempsJournee == false && test == false )
        {
            test = true;
            chercheArbre();

        }
        else
        {
         
        }

        
    }
    void chercheArbre() 
    {
        GameObject[] arbres = GameObject.FindGameObjectsWithTag("arbre");
        int indexArbres = Random.Range(0, arbres.Length);
        //navAgent.SetDestination(arbres[indexArbres].transform.position);

    }
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Fox Principal" && CycleJour.tempsJournee == true)
        {
            GetComponent<Animator>().SetTrigger("attaque");

        }
        if (collision.gameObject.tag == "arbre")
        {
            chercheArbre();

        }

    }

}

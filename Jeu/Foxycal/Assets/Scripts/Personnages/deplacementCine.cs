using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class deplacementCine : MonoBehaviour
{
    // L'objet vers où les renards se déplacent
    public GameObject cibleBebe;
    public GameObject cibleExterieur;

    NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
        // Raccourcir la variable du NavMeshAgent
        navAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(marchePerso());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator marchePerso()
    {
        navAgent.SetDestination(cibleBebe.transform.position);

        yield return new WaitForSeconds(2);

        navAgent.enabled = false;
        GetComponent<Animator>().SetBool("marche", false);
        GetComponent<Animator>().SetBool("idle", true);

        yield return new WaitForSeconds(4);

        GetComponent<Animator>().SetBool("marche", true);
        GetComponent<Animator>().SetBool("idle", false);
        navAgent.enabled = true;
        navAgent.SetDestination(cibleExterieur.transform.position);

        yield return new WaitForSeconds(7);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}

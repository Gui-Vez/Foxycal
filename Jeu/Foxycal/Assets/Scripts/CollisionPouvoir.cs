using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPouvoir : MonoBehaviour
{
    GameObject RefEnnemi;
    public int pointDeVie;
    

    void Start()
    {
        RefEnnemi = gameObject;

        pointDeVie = 3;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pouvoir"))
        {
            DiminuerVie();

            GetComponent<Animator>().SetTrigger("estAttaqué");

            
        }
    }

    void DiminuerVie()
    {
        pointDeVie--;

        if (pointDeVie == 0)
        {
            GetComponent<Animator>().SetTrigger("mort");
            Invoke("EnleverEnnemi", 2f);
        }
    }

    void EnleverEnnemi()
    {
        Destroy(gameObject);
    }
}

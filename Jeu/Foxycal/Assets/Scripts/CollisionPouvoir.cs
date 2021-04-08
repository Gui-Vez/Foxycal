using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPouvoir : MonoBehaviour
{
    GameObject RefEnnemi;
    int pointDeVie;

    void Start()
    {
        RefEnnemi = gameObject;

        pointDeVie = 3;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pouvoir"))
        {
            if (CompareTag("Ennemi"))
            {
                DiminuerVie();
            }
        }
    }

    void DiminuerVie()
    {
        pointDeVie--;

        if (pointDeVie == 0)
        {
            EnleverEnnemi();
        }
    }

    void EnleverEnnemi()
    {
        Destroy(gameObject);
    }
}

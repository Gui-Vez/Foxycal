using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTest : MonoBehaviour
{
    RaycastHit hit;



    void Update()
    {
        /*
        if (Physics.SphereCast(transform.position, 1, transform.forward, out hit))
        {
            print(hit);
        }
        */

        /*
        if (Physics.CheckSphere(transform.position, 1))
        {
            print("ici");
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            print("Le renard peut manger");
        }
    }
}

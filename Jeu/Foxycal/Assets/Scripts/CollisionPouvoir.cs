using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPouvoir : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pouvoir"))
        {
            if (gameObject.name == "Cube Rouge")
            {
                Destroy(gameObject);
            }
        }
    }
}

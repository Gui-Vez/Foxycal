using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accesSceneFin : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Fox Principal")
        {
            SceneManager.LoadScene("Fin");
        }
    }
}

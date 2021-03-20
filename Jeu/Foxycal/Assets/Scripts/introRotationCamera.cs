using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introRotationCamera : MonoBehaviour
{

    public float vitesse;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, vitesse * Time.deltaTime, 0);
    }
}

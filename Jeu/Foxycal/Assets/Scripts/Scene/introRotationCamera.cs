using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introRotationCamera : MonoBehaviour
{
    /// Auteur : Tristan Lapointe
    /// Description : Faire tourner la caméra d'introduction

    public float vitesse;
    
    // À chaque frame,
    void Update()
    {
        // Exercer une rotation
        transform.Rotate(0, vitesse * Time.deltaTime, 0);
    }
}

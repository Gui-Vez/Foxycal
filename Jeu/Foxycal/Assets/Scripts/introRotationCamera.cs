using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introRotationCamera : MonoBehaviour
{
    /// Auteur : Tristan Lapointe
    /// Description : Faire tourner la cam�ra d'introduction

    public float vitesse;
    
    // � chaque frame,
    void Update()
    {
        // Exercer une rotation
        transform.Rotate(0, vitesse * Time.deltaTime, 0);
    }
}

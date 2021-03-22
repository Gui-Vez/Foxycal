using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDeplacement : MonoBehaviour
{
    bool W;
    bool A;
    bool S;
    bool D;

    bool Up;
    bool Left;
    bool Down;
    bool Right;

    private bool peutAvancer;


    void Update()
    {
        /****************/
        /* DÉPLACEMENTS */
        /****************/

        // Touches WASD
        W = Input.GetKey(KeyCode.W);
        A = Input.GetKey(KeyCode.A);
        S = Input.GetKey(KeyCode.S);
        D = Input.GetKey(KeyCode.D);

        // Touches Flèchées
        Up    = Input.GetKey(KeyCode.UpArrow);
        Left  = Input.GetKey(KeyCode.LeftArrow);
        Down  = Input.GetKey(KeyCode.DownArrow);
        Right = Input.GetKey(KeyCode.RightArrow);


        // Si le renard n'attaque pas,
        if (!GestionPouvoirs.attaque)
        {
            // Gérer l'animation de marche
            GererAnimations();
        }
    }

    void GererAnimations()
    {
        // Gestion des animations
        if      (W || Up)    GetComponent<Animator>().SetBool("Marche", true);
        else if (A || Left)  GetComponent<Animator>().SetBool("Marche", true);
        else if (S || Down)  GetComponent<Animator>().SetBool("Marche", true);
        else if (D || Right) GetComponent<Animator>().SetBool("Marche", true);
        else                 GetComponent<Animator>().SetBool("Marche", false);
    }
}
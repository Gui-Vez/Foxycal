using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementRenard : MonoBehaviour
{
    bool W;
    bool A;
    bool S;
    bool D;

    bool Up;
    bool Left;
    bool Down;
    bool Right;

    private bool attaque;
    private bool peutAvancer;
    public float vitesseRotation;
    public float vitesseTranslation;



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

        // Gestion des translations
        if (W || Up)    GererTranslation("Haut");
        if (A || Left)  GererTranslation("Gauche");
        if (S || Down)  GererTranslation("Bas");
        if (D || Right) GererTranslation("Droite");



        /************/
        /* ATTAQUES */
        /************/

        // Clic gauche
        if (Input.GetKey(KeyCode.Mouse0))
        {
            // Si le renard n'attaque pas,
            if (!attaque)
            {
                // Activer une attaque
                StartCoroutine(GererAttaques());
            }
        }



        /**************/
        /* ANIMATIONS */
        /**************/

        // ...
    }

    void GererTranslation(string dir)
    {
        // Bouger le personnage selon sa direction
        switch (dir)
        {
            case "Haut"  : transform.Translate(0, 0, vitesseTranslation);  break;
            case "Gauche": transform.Translate(-vitesseTranslation, 0, 0); break;
            case "Bas"   : transform.Translate(0, 0, -vitesseTranslation); break;
            case "Droite": transform.Translate(vitesseTranslation, 0, 0);  break;
        }
    }

    IEnumerator GererAttaques()
    {
        print("Début attaque");

        attaque = true;

        yield return new WaitForSeconds(2f);

        attaque = false;

        print("Fin attaque");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPouvoirs : MonoBehaviour
{
    // Attaques
    bool E;
    bool R;
    bool T;

    // Souris
    bool LMC;
    bool RMC;

    List<List<bool>> ListeTouches;

    public static bool attaque;


    void Update()
    {
        E = Input.GetKey(KeyCode.E);
        R = Input.GetKey(KeyCode.R);
        T = Input.GetKey(KeyCode.T);

        LMC = Input.GetKey(KeyCode.Mouse0);
        RMC = Input.GetKey(KeyCode.Mouse1);


        List<bool> ListeTouchesAttaques = new List<bool>()
        { E, R, T, LMC, RMC };

        // ListeTouches.Add(ListeTouchesAttaques);
        // foreach (bool Touches in ListeTouches)


        // Si l'on touche à n'importe quelle touche,
        if (Input.anyKeyDown)
        {
            // Touches des attaques
            if (LMC) StartCoroutine(GestionAttaques("LMC"));
            if (RMC) StartCoroutine(GestionAttaques("RMC"));

            // Touches des pouvoirs
            if (E) StartCoroutine(GestionAttaques("E"));
            if (R) StartCoroutine(GestionAttaques("R"));
            if (T) StartCoroutine(GestionAttaques("T"));
        }
    }


    IEnumerator GestionAttaques(string Attaque)
    {
        if (!attaque)
        {
            switch (Attaque)
            {
                /************/
                /* ATTAQUES */
                /************/

                case "LMC":

                    print("Début attaque");

                    // Le renard attaque
                    attaque = true;

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", true);

                    // Activer l'animation d'attaque Gauche
                    GetComponent<Animator>().SetTrigger("Attaque_L");

                    // Attendre 1.25 secondes
                    yield return new WaitForSeconds(1.25f);

                    // Désactiver l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", false);

                    // Le renard n'agit plus
                    attaque = false;

                    print("Fin attaque");

                    break;


                case "RMC":

                    print("Début attaque");

                    // Le renard attaque
                    attaque = true;

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", true);

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetTrigger("Attaque_R");

                    // Attendre 1.5 secondes
                    yield return new WaitForSeconds(1.25f);

                    // Désactiver l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", false);

                    // Le renard n'agit plus
                    attaque = false;

                    print("Fin attaque");

                    break;




                /************/
                /* POUVOIRS */
                /************/

                case "E":

                    print("Début pouvoir");

                    // Le renard attaque
                    attaque = true;

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", true);

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetTrigger("Pouvoir");

                    // Attendre 1.5 secondes
                    yield return new WaitForSeconds(1.25f);

                    // Désactiver l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", false);

                    // Attendre 3.75 secondes
                    yield return new WaitForSeconds(3.75f);

                    // Le renard n'agit plus
                    attaque = false;

                    print("Fin pouvoir");

                    break;


                case "R":

                    print("Début pouvoir");

                    // Le renard attaque
                    attaque = true;

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", true);

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetTrigger("Pouvoir");

                    // Attendre 1.5 secondes
                    yield return new WaitForSeconds(1.25f);

                    // Désactiver l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", false);

                    // Attendre 6.75 secondes
                    yield return new WaitForSeconds(6.75f);

                    // Le renard n'agit plus
                    attaque = false;

                    print("Fin pouvoir");

                    break;


                case "T":

                    print("Début pouvoir");

                    // Le renard attaque
                    attaque = true;

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", true);

                    // Activer l'animation d'attaque
                    GetComponent<Animator>().SetTrigger("Pouvoir");

                    // Attendre 1.5 secondes
                    yield return new WaitForSeconds(1.25f);

                    // Désactiver l'animation d'attaque
                    GetComponent<Animator>().SetBool("Attaque", false);

                    // Attendre 11.75 secondes
                    yield return new WaitForSeconds(11.75f);

                    // Le renard n'agit plus
                    attaque = false;

                    print("Fin pouvoir");

                    break;
            }
        }
    }
}
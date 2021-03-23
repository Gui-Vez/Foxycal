using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPouvoirs : MonoBehaviour
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
    public static bool pouvoir;
    public static bool manger;


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


        // Si l'on touche n'importe quelle touche du clavier,
        if (Input.anyKeyDown)
        {
            // Si une attaque n'est pas en cours,
            if (!attaque)
            {
                // Touche des attaques
                if (LMC) StartCoroutine(GestionAttaques("LMC"));
            }

            // Si le renard n'est pas en train de manger,
            if (!manger)
            {
                // Touche pour manger
                if (RMC) StartCoroutine(GestionAttaques("RMC"));
            }

            // Si un pouvoir n'est pas activé,
            if (!pouvoir)
            {
                // Touches des pouvoirs
                if (E) StartCoroutine(GestionAttaques("E"));
                if (R) StartCoroutine(GestionAttaques("R"));
                if (T) StartCoroutine(GestionAttaques("T"));
            }
        }
    }


    IEnumerator GestionAttaques(string Attaque)
    {
        switch (Attaque)
        {
            /************/
            /* ATTAQUES */
            /************/

            case "LMC":

                // Le renard attaque
                attaque = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation d'attaque Gauche
                GetComponent<Animator>().SetTrigger("Attaque_L");

                // Attendre 1 seconde
                yield return new WaitForSeconds(1f);

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Le renard n'agit plus
                attaque = false;

                break;


            case "RMC":

                print("mange");

                // Le renard mange
                manger = true;

                // Activer l'animation de manger
                GetComponent<Animator>().SetBool("Mange", true);

                // Attendre 3 secondes
                yield return new WaitForSeconds(3f);

                // Désactiver l'animation de manger
                GetComponent<Animator>().SetBool("Mange", false);

                // Le renard n'agit plus
                manger = false;

                print("mange pu");

                break;




            /************/
            /* POUVOIRS */
            /************/

            case "E":

                // Le renard envoie un pouvoir
                pouvoir = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetTrigger("Pouvoir_Trigger");

                // Attendre 0.75 secondes
                yield return new WaitForSeconds(0.75f);

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Attendre 4.25 secondes
                yield return new WaitForSeconds(4.25f);

                // Le renard n'agit plus
                pouvoir = false;

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", false);

                break;


            case "R":

                // Le renard envoie un pouvoir
                pouvoir = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetTrigger("Pouvoir_Trigger");

                // Attendre 0.75 secondes
                yield return new WaitForSeconds(0.75f);

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Attendre 7.25 secondes
                yield return new WaitForSeconds(7.25f);

                // Le renard n'agit plus
                pouvoir = false;

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", false);

                break;


            case "T":

                // Le renard envoie un pouvoir
                pouvoir = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetTrigger("Pouvoir_Trigger");

                // Attendre 0.75 secondes
                yield return new WaitForSeconds(0.75f);

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Attendre 12.25 secondes
                yield return new WaitForSeconds(12.25f);

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", false);

                // Le renard n'agit plus
                pouvoir = false;

                break;
        }
    }
}
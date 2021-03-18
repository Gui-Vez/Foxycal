using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionAnimations : MonoBehaviour
{
    // Attaques
    bool E;
    bool R;
    bool T;

    // Souris
    bool LMC;
    bool RMC;

    List<List<bool>> ListeTouches;


    void Update()
    {
        E = Input.GetKey(KeyCode.E);
        R = Input.GetKey(KeyCode.R);
        T = Input.GetKey(KeyCode.T);

        LMC = Input.GetKey(KeyCode.Mouse0);
        RMC = Input.GetKey(KeyCode.Mouse1);


        List<bool> ListeTouchesAttaques = new List<bool>()
        { E, R, T, LMC, RMC };

        ListeTouches.Add(ListeTouchesAttaques);


        if (Input.anyKeyDown)
        {
            /* foreach (bool Touches in ListeTouches) */

            if (E) StartCoroutine(AppuyerTouche("E"));
            if (E) StartCoroutine(AppuyerTouche("R"));
        }
    }


    IEnumerator AppuyerTouche(string Touche)
    {
        switch (Touche)
        {
            case "E": StartCoroutine(GestionAttaques("E")); break;
            case "R": StartCoroutine(GestionAttaques("R")); break;
        }

        yield return null;
    }

    IEnumerator GestionAttaques(string Attaque)
    {
        switch (Attaque)
        {
            case "E":

                print("Début Pouvoir");

                yield return new WaitForSeconds(2);

                print("Fin Pouvoir");

                break;
        }
    }
}
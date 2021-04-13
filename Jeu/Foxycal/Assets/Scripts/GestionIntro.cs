using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionIntro : MonoBehaviour
{
    public GameObject[] ObjetsMenuPrincipal;
    public GameObject[] ObjetsMenuControles;
    public GameObject[] ObjetsMenuCredits;
    public GameObject menuRetour;


    public void AffichageMenu(string menu)
    {
        switch (menu)
        {
            case "Principal":

                foreach (GameObject menuPrincipal in ObjetsMenuPrincipal) menuPrincipal.SetActive(true);
                foreach (GameObject menuControle in ObjetsMenuControles) menuControle.SetActive(false);
                foreach (GameObject menuCredit in ObjetsMenuCredits) menuCredit.SetActive(false);

                menuRetour.SetActive(false);

                break;


            case "Controles":

                foreach (GameObject menuPrincipal in ObjetsMenuPrincipal) menuPrincipal.SetActive(false);
                foreach (GameObject menuControle in ObjetsMenuControles) menuControle.SetActive(true);
                foreach (GameObject menuCredit in ObjetsMenuCredits) menuCredit.SetActive(false);

                menuRetour.SetActive(true);

                break;


            case "Credits":

                foreach (GameObject menuPrincipal in ObjetsMenuPrincipal) menuPrincipal.SetActive(false);
                foreach (GameObject menuControle in ObjetsMenuControles) menuControle.SetActive(false);
                foreach (GameObject menuCredit in ObjetsMenuCredits) menuCredit.SetActive(true);

                menuRetour.SetActive(true);

                break;


            default:

                Debug.LogWarning("Choix de menu invalide");

                break;
        }
    }
}

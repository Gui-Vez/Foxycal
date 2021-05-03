using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class GestionEffetFruit : MonoBehaviour
{
    GameObject[] Ennemis;
    public Transform lumiere;
    public Slider barreVie;

    void Start()
    {
        Ennemis = GameObject.FindGameObjectsWithTag("Ennemi");
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.transform.name)
        {
            case "Boumis" : StartCoroutine("GestionEffets", "Boumis");  break;
            case "Galins" : StartCoroutine("GestionEffets", "Galins");  break;
            case "Etilius": StartCoroutine("GestionEffets", "Etilius"); break;
            case "Fidiame": StartCoroutine("GestionEffets", "Fidiame"); break;
            case "Gidius" : StartCoroutine("GestionEffets", "Gidius");  break;
            case "Luju"   : StartCoroutine("GestionEffets", "Luju");    break;
            case "Machi"  : StartCoroutine("GestionEffets", "Machi");   break;
            case "Pitarus": StartCoroutine("GestionEffets", "Pitarus"); break;
            case "Lubana" : StartCoroutine("GestionEffets", "Lubana");  break;
        }
    }

    IEnumerator GestionEffets(string effet)
    {
        switch (effet)
        {
            // Arrêter les ennemis pendant quelques secondes
            case "Boumis":

                for (int i = 0; i < Ennemis.Length; i++)
                {
                    Ennemis[i].GetComponent<NavMeshAgent>().speed = 0;
                    Ennemis[i].GetComponent<Animator>().enabled = false;

                    yield return new WaitForSeconds(12);

                    Ennemis[i].GetComponent<NavMeshAgent>().speed = 2.5f;
                    Ennemis[i].GetComponent<Animator>().enabled = true;
                }

                break;


            // Bonus de faim
            case "Galins":

                gestionFaimPersonnage.faim += 50;

                yield return new WaitForSeconds(12);

                gestionFaimPersonnage.faim -= 30;

                break;


            // Jour instantané
            case "Etilius":

                lumiere.eulerAngles = new Vector3(0, 0, 0);

                break;


            // Riiiieeeen
            case "Fidiame":
                

                
                break;


            // Bonus de vie
            case "Gidius":

                barreVie.value += 5;

                yield return new WaitForSeconds(6);

                barreVie.value -= 3;

                break;


            // Temps de recharge 1 seconde
            case "Luju":

                /*
                GestionPouvoirs.TempsPouvoir1 = 1;
                GestionPouvoirs.TempsPouvoir2 = 1;
                GestionPouvoirs.TempsPouvoir3 = 1;

                yield return new WaitForSeconds(6);

                GestionPouvoirs.TempsPouvoir1 = 4;
                GestionPouvoirs.TempsPouvoir2 = 3;
                GestionPouvoirs.TempsPouvoir3 = 6;
                */

                break;


            // Augmentation de la vitesse
            case "Machi":

                Deplacement3ePerso.vitesse += 4.5f;

                yield return new WaitForSeconds(6);

                Deplacement3ePerso.vitesse -= 5f;

                break;


            // Nuit instantanée
            case "Pitarus":

                lumiere.eulerAngles = new Vector3(180, 0, 0);

                break;


            // Augmenter saut
            case "Lubana":



                break;
        }

        yield return null;
    }
}

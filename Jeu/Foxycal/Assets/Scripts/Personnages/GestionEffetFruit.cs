using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class GestionEffetFruit : MonoBehaviour
{
    
    public Transform lumiere;
    public Slider barreVie;

    void Start()
    {
        
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
                effetBoumis();
                yield return new WaitForSeconds(12);
                effetBoumisRetour();
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


            // Rien
            case "Fidiame":

                // Vide

                break;
                


            // Bonus de vie
            case "Gidius":

                barreVie.value += 5;

                yield return new WaitForSeconds(6);

                barreVie.value -= 3;

                break;


            // Temps de recharge 1 seconde
            case "Luju":

                GestionAnimations.TempsE -= 5;
                GestionAnimations.TempsR -= 3;
                GestionAnimations.TempsT -= 4;

                yield return new WaitForSeconds(10);

                GestionAnimations.TempsE += 6;
                GestionAnimations.TempsR += 4;
                GestionAnimations.TempsT += 5;

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

                Deplacement3ePerso.forceSaut += 1.5f;

                yield return new WaitForSeconds(8);

                Deplacement3ePerso.forceSaut -= 1.75f;

                break;
        }

        yield return null;
    }

    public void effetBoumis()
    {
        GameObject[] Ennemis = GameObject.FindGameObjectsWithTag("Ennemi");

        for (int i = 0; i < Ennemis.Length; i++){
            print(i);
            Ennemis[i].gameObject.GetComponent<NavMeshAgent>().speed = 0f;
            Ennemis[i].gameObject.GetComponent<Animator>().enabled = false;
            }
    }

    public void effetBoumisRetour()
    {
        GameObject[] Ennemis = GameObject.FindGameObjectsWithTag("Ennemi");
        for (int i = 0; i < Ennemis.Length; i++)
        {
            print(i);
            Ennemis[i].gameObject.GetComponent<NavMeshAgent>().speed = 2.5f;
            Ennemis[i].gameObject.GetComponent<Animator>().enabled = true;
        }
    }
}

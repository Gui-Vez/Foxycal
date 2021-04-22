using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionQuete : MonoBehaviour
{
    /// Auteur : Guillaume V�zina
    /// Description : G�re les qu�tes du jeu

    public List<string> listeQuetes;
    public List<Text> listeNomsQuetes;
    public List<int> listeNombreQuete;
    public List<int> listeNombreMaxQuete;
    public GameObject portail;
    public static bool portailOuvert;

    void Update()
    {
        // Pour chaque qu�te,
        for (int i = 0; i < listeQuetes.Count; i++)
        {
            // Ins�rer le texte de cette qu�te
            listeNomsQuetes[i].text = listeQuetes[i];

            // S'il y a un nombre � atteindre pour cette qu�te,
            if (listeNombreMaxQuete[i] != 0)
            {
                // Ajouter un compteur de qu�te
                listeNomsQuetes[i].text += " (" + listeNombreQuete[i] + "/" + listeNombreMaxQuete[i] + " )";
            }
        }
        

    }

    public void AugmenterNumeroQuete(int numero)
    {
        // Si le num�ro de la qu�te est inf�rieure � son maximum,
        if (listeNombreQuete[numero] < listeNombreMaxQuete[numero])
        {
            // Augmenter le numero de la qu�te
            listeNombreQuete[numero]++;
        }

        if(listeNombreMaxQuete[numero] == listeNombreQuete[numero])
        {
            portailOuvert = true;
            portail.GetComponent<Renderer>().material.color = Color.green;

        }

    }
}

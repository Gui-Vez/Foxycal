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

    public void AugmenterNombre(int nombre)
    {
        switch (nombre)
        {
            case 1:

                break;

            case 2:

                break;

            case 3:

                break;

            default:

                break;
        }
    }
}

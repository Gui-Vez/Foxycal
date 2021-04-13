using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionQuete : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Gère les quêtes du jeu

    public List<string> listeQuetes;
    public List<Text> listeNomsQuetes;
    public List<int> listeNombreQuete;
    public List<int> listeNombreMaxQuete;

    void Update()
    {
        // Pour chaque quête,
        for (int i = 0; i < listeQuetes.Count; i++)
        {
            // Insérer le texte de cette quête
            listeNomsQuetes[i].text = listeQuetes[i];

            // S'il y a un nombre à atteindre pour cette quête,
            if (listeNombreMaxQuete[i] != 0)
            {
                // Ajouter un compteur de quête
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

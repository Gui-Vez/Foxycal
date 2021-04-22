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
    public GameObject portail;
    public static bool portailOuvert;
    public GameObject[] Lanternes;

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

    public void AugmenterNumeroQuete(int numero)
    {
        // Si le numéro de la quête est inférieure à son maximum,
        if (listeNombreQuete[numero] < listeNombreMaxQuete[numero])
        {
            // Augmenter le numero de la quête
            listeNombreQuete[numero]++;
        }

        // Si la quête touche à son maximum,
        if (listeNombreQuete[numero] == listeNombreMaxQuete[numero])
        {
            // Ouvrir le portail
            portailOuvert = true;

            // Changer la couleur du portail pour être vert
            portail.GetComponent<Renderer>().material.color = Color.green;

            // Pour chaque lanterne du portail,
            foreach (GameObject lanterne in Lanternes)
            {
                // Activer la lumière de la lanterne
                lanterne.GetComponent<Light>().enabled = true;
            }
        }

    }
}

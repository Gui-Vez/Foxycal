using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionScore : MonoBehaviour
{
    /// Auteur : Guillaume V�zina
    /// Description : G�re le pointage obtenu lors du jeu

    public GameObject GestionnaireScore;
    public static int score;

    void Update()
    {
        GestionnaireScore.GetComponent<Text>().text = score.ToString();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy et Guillaume
 * Description: Un script qui gère le déplacement du personnnage...
 * Dernière modification: 5 mars 2021
 ****************************************************************************************************/

public class Deplacement3ePerso : MonoBehaviour
{
    // Variables pour le déplacement du personnage
    public float vitesse;
    public float forceSaut;
    public bool isGrounded;
    public Vector3 saut;

    public static bool peutSauter;
    public static bool peutBouger;

    // Accès de Rigidbody
    private Rigidbody rig;

    // Variables pour la gestion de la caméra 3e personne
    public GameObject pivotVide;
    public GameObject cam3ePerso;

    // Petit raccourcis
    // Valeurs pour le saut
    // Valeurs booléennes pour gérer si le personnage peut bouger (en liaison avec le script des animations) ou sauter
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        saut = new Vector3(0f, 2f, 0f);
        // Verouiller la souris
        Cursor.lockState = CursorLockMode.Locked;

        peutBouger = true;
        peutSauter = true;
    }

    // Détecte si le personnage touche quelque chose
    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Détecte si le personnage n'est pas en contact avec quelque chose
    void OnCollisionExit()
    {
        isGrounded = false;
    }

    // Les mouvements de base
    void Update()
    {
        // Gestion du mouvement WASD
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 deplacement = cam3ePerso.transform.forward * vertical​ + cam3ePerso.transform.right * horizontal;

        deplacement.y = 0;

        //S'il y a du movement, le personnage peut bouger
        if (deplacement != Vector3.zero && peutBouger == true)
        {
            // Oriente le personnage vers la direction des touches
            transform.forward = deplacement;
            rig.velocity = (transform.forward * vitesse) + new Vector3(0, rig.velocity.y, 0);
            
        }

        else
        {
            rig.velocity = new Vector3(0, rig.velocity.y, 0);
        }

        // Gestion du saut du personnage
        if (Input.GetKeyDown(KeyCode.Space) && peutSauter && isGrounded)
        {
            rig.AddForce(saut * forceSaut, ForceMode.Impulse);
            peutSauter = false;
        }
    }
}

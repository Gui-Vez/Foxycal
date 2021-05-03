using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionAnimations : MonoBehaviour
{
    /// Auteur : Guillaume Vézina
    /// Description : Gère les animations de déplacement du personnage
    public AudioClip sonManger;

    // Liste des touches (Inutilisée)
    List<List<bool>> ListeTouches;

    // Raccourci du RigidBody (Inutilisé)
    Rigidbody rb;

    // WASD
    bool W;
    bool A;
    bool S;
    bool D;

    // Flèches
    bool Up;
    bool Left;
    bool Down;
    bool Right;

    // Saut
    bool Space;

    // Attaques
    bool E;
    bool R;
    bool T;

    // Souris
    bool LMC;
    bool RMC;

    // Liste des actions
    bool action;
    bool attaque;
    bool pouvoirE;
    bool pouvoirR;
    bool pouvoirT;
    bool manger;
    bool saute;

    // Temps avant les pouvoirs
    public int TempsE;
    public int TempsR;
    public int TempsT;



    void Start()
    {
        // Raccourci du rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        /***********/
        /* TOUCHES */
        /***********/

        // Liste des touches
        List<bool> ListeTouches = new List<bool>()
        { W, A, S, D, Up, Left, Down, Right, Space, E, R, T, LMC, RMC };

        // Touches WASD
        W = Input.GetKey(KeyCode.W);
        A = Input.GetKey(KeyCode.A);
        S = Input.GetKey(KeyCode.S);
        D = Input.GetKey(KeyCode.D);

        // Touches Flèchées
        Up    = Input.GetKey(KeyCode.UpArrow);
        Left  = Input.GetKey(KeyCode.LeftArrow);
        Down  = Input.GetKey(KeyCode.DownArrow);
        Right = Input.GetKey(KeyCode.RightArrow);

        // Touche de Saut
        Space = Input.GetKey(KeyCode.Space);

        // Touches Pouvoirs
        E = Input.GetKey(KeyCode.E);
        R = Input.GetKey(KeyCode.R);
        T = Input.GetKey(KeyCode.T);

        // Touche Attaque
        LMC = Input.GetKey(KeyCode.Mouse0);

        // Touche Manger
        RMC = Input.GetKey(KeyCode.Mouse1);


        // Animation de marche
        if (gestionFaimPersonnage.mort != true)
        {
            if (W || Up) GetComponent<Animator>().SetBool("Marche", true);
            else if (A || Left) GetComponent<Animator>().SetBool("Marche", true);
            else if (S || Down) GetComponent<Animator>().SetBool("Marche", true);
            else if (D || Right) GetComponent<Animator>().SetBool("Marche", true);
            else GetComponent<Animator>().SetBool("Marche", false);
        }


        // Si l'on touche n'importe quelle touche du clavier ET que le renard n'agit pas, ET que le renard n'est pas mort,
        if (Input.anyKeyDown && !action && gestionFaimPersonnage.mort != true)
        {
            // Si le renard n'est pas en train de manger,
            if (!manger)
            {
                // Touche pour manger
                if (RMC) StartCoroutine(GestionAttaques("RMC"));
            }

            // Si le renard ne saute pas,
            if (!saute)
            {
                // Touche du saut
                if (Space) StartCoroutine(GestionAttaques("Space"));
            }

            // Si c'est la nuit,
            if (CycleJour.tempsJournee)
            {
                // Si une attaque n'est pas en cours,
                if (!attaque)
                {
                    // Touche des attaques
                    if (LMC) StartCoroutine(GestionAttaques("LMC"));
                }

                // Si un pouvoir n'est pas activé,
                if (!pouvoirE)
                {
                    // Touches des pouvoirs
                    if (E) StartCoroutine(GestionAttaques("E"));
                }

                // Si un pouvoir n'est pas activé,
                if (!pouvoirR)
                {
                    // Touches des pouvoirs
                    if (R) StartCoroutine(GestionAttaques("R"));
                }

                // Si un pouvoir n'est pas activé,
                if (!pouvoirT)
                {
                    // Touches des pouvoirs
                    if (T) StartCoroutine(GestionAttaques("T"));
                }
            }
        }

        
    }


    IEnumerator GestionAttaques(string Animation)
    {

        // Le renard agit
        action = true;

        // Le renard ne peut pas sauter
        Deplacement3ePerso.peutSauter = false;

        switch (Animation)
        {
            /************/
            /* ATTAQUES */
            /************/

            case "LMC":

                // Le renard attaque
                attaque = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation d'attaque Gauche
                GetComponent<Animator>().SetTrigger("Attaque_L");

                // Lancer un pouvoir
                GetComponent<GestionPouvoirs>().StartCoroutine("LancerPouvoir", "LMC");

                // Baisser la vitesse de déplacement
                Deplacement3ePerso.vitesse /= 3;

                // Attendre 1 seconde
                yield return new WaitForSeconds(1f);

                // Augmenter la vitesse de déplacement
                Deplacement3ePerso.vitesse = Deplacement3ePerso.vitesseMax;

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Le renard n'attaque plus
                attaque = false;

                // Le renard n'agit plus
                action = false;
                
                break;



            /**********/
            /* MANGER */
            /**********/

            case "RMC":


                // Le renard mange
                manger = true;

                // Activer l'animation de manger
                GetComponent<Animator>().SetBool("Mange", true);
                GetComponent<AudioSource>().PlayOneShot(sonManger, 2f);

                Deplacement3ePerso.peutBouger = false;

                // GetComponent<UnScript>().faim -= 1f * Time.deltaTime;

                // Attendre 3 secondes
                yield return new WaitForSeconds(3f);

                // Désactiver l'animation de manger
                GetComponent<Animator>().SetBool("Mange", false);

                Deplacement3ePerso.peutBouger = true;

                // Le renard ne mange plus
                manger = false;

                // Le renard n'agit plus
                action = false;

                break;



            /********/
            /* SAUT */
            /********/

            case "Space":

                // Le renard saute
                saute = true;

                // Activer l'animation de saut
                GetComponent<Animator>().SetBool("Saute", true);

                // Le renard peut sauter
                Deplacement3ePerso.peutSauter = true;

                // Attendre 1 seconde
                yield return new WaitForSeconds(1f);

                // Désactiver l'animation de saut
                GetComponent<Animator>().SetBool("Saute", false);

                // Le renard ne saute plus
                saute = false;

                // Le renard n'agit plus
                action = false;

                break;



            /************/
            /* POUVOIRS */
            /************/

            case "E":

                // Le renard envoie un pouvoir
                pouvoirE = true;

                // Vider la barre du pouvoir 1
                GetComponent<GestionPouvoirs>().ViderPouvoir(1);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir", true);

                // Lancer un pouvoir
                GetComponent<GestionPouvoirs>().StartCoroutine("LancerPouvoir", "E");

                // Baisser la vitesse de déplacement
                Deplacement3ePerso.vitesse /= 2;

                // Attendre 1 seconde
                yield return new WaitForSeconds(1f);

                // Augmenter la vitesse de déplacement
                Deplacement3ePerso.vitesse = Deplacement3ePerso.vitesseMax;

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir", false);

                // Le renard n'agit plus
                action = false;

                // Attendre 4 secondes
                yield return new WaitForSeconds(TempsE);

                // Le renard n'agit plus
                pouvoirE = false;

                break;


            case "R":

                // Le renard envoie un pouvoir
                pouvoirR = true;

                // Vider la barre du pouvoir 2
                GetComponent<GestionPouvoirs>().ViderPouvoir(2);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir", true);

                // Lancer un pouvoir
                GetComponent<GestionPouvoirs>().StartCoroutine("LancerPouvoir", "R");

                // Baisser la vitesse de déplacement
                Deplacement3ePerso.vitesse /= 2;

                // Attendre 1 seconde
                yield return new WaitForSeconds(1f);

                // Augmenter la vitesse de déplacement
                Deplacement3ePerso.vitesse = Deplacement3ePerso.vitesseMax;

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir", false);

                // Le renard n'agit plus
                action = false;

                // Attendre 7 secondes
                yield return new WaitForSeconds(TempsR);

                // Le renard n'agit plus
                pouvoirR = false;

                break;


            case "T":

                // Le renard envoie un pouvoir
                pouvoirT = true;

                // Vider la barre du pouvoir 3
                GetComponent<GestionPouvoirs>().ViderPouvoir(3);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir", true);

                // Lancer un pouvoir
                GetComponent<GestionPouvoirs>().StartCoroutine("LancerPouvoir", "T");

                // Baisser la vitesse de déplacement
                Deplacement3ePerso.vitesse /= 2;

                // Attendre 1 seconde
                yield return new WaitForSeconds(1f);

                // Augmenter la vitesse de déplacement
                Deplacement3ePerso.vitesse = Deplacement3ePerso.vitesseMax;

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir", false);

                // Le renard n'agit plus
                action = false;

                // Attendre 11 secondes
                yield return new WaitForSeconds(TempsT);

                // Le renard n'agit plus
                pouvoirT = false;

                break;
        }

        // Le renard peut sauter
        Deplacement3ePerso.peutSauter = true;
    }
}
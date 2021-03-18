using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement3ePerso : MonoBehaviour
{
    // Variables pour le déplacement du personnage
    public float vitesse;
    public float forceSaut;
    public bool isGrounded;
    public Vector3 saut;
    private Rigidbody rig;

    // Variables pour la gestion de la caméra 3e personne
    public GameObject pivotVide;
    public GameObject cam3ePerso;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        saut = new Vector3(0f, 2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Gestion du mouvement WASD
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 deplacement = cam3ePerso.transform.forward * vertical​ + cam3ePerso.transform.right * horizontal;

        deplacement.y = 0;

        if (deplacement != Vector3.zero)
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
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rig.AddForce(saut * forceSaut, ForceMode.Impulse);
            isGrounded = false;
        }

    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }
}

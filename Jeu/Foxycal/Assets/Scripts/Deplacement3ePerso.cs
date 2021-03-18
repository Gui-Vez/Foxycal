using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement3ePerso : MonoBehaviour
{

    public float vitesse;
    public float forceSaut;
    public bool isGrounded;
    public Vector3 saut;

    private Rigidbody rig;

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
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(horizontal * vitesse * Time.deltaTime, 0f, vertical * vitesse * Time.deltaTime);

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

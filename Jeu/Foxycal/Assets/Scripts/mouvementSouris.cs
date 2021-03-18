using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementSouris : MonoBehaviour
{

    public float sensSouris = 100f;
    public Transform personnage;
    float rotationVertical = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(personnage.transform);

        float mouseX = Input.GetAxis("Mouse X") * sensSouris * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensSouris * Time.deltaTime;

        rotationVertical -= mouseY;

        // Limiter la rotation de la camera
        rotationVertical = Mathf.Clamp(rotationVertical, 0f, 0f);

        // Quaternion (XYZW en 3 vecteurs)
        transform.localRotation = Quaternion.Euler(rotationVertical, 0f, 0f);

        // Faire tourner sur l'axe Horizontal
        personnage.Rotate(Vector3.up * mouseX);
    }
}

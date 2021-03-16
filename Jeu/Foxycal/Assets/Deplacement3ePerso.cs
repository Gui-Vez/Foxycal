using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement3ePerso : MonoBehaviour
{

    public float vitesse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * vitesse * Time.deltaTime, 0f, Input.GetAxis("Vertical") * vitesse * Time.deltaTime);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPivot : MonoBehaviour
{

    public GameObject camSurPerso;
    public GameObject cam3ePerso;
    public GameObject positionRayCastCam;
    public float hauteurPivot;
    public float distanceCamLoin = -4f;
    public float distanceCamProche = -0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = camSurPerso.transform.position + new Vector3(0, hauteurPivot, 0);
        transform.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);

        if (Physics.Raycast(positionRayCastCam.transform.position, positionRayCastCam.transform.forward, distanceCamLoin))
        {
            cam3ePerso.transform.localPosition = new Vector3(0, 1, distanceCamProche);
        }

        else
        {
            cam3ePerso.transform.localPosition = new Vector3(0, 0, distanceCamLoin);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barreDeFaimScript : MonoBehaviour
{
    public Slider sliderFaim;

    public float faimMax = 100f;
    public float faim;

    // Start is called before the first frame update
    void Start()
    {
        faim = faimMax;
    }

    // Update is called once per frame
    void Update()
    {
        sliderFaim.value = faim;
        faim -= 0.5f * Time.deltaTime;
    }
}

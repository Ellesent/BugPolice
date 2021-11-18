using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
     private bool isOn = true;

     [SerializeField]
     Light lampLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

        // Turn on and off lamp on click
        // TODO Possibly move to a state machine
        if (isOn) {
            lampLight.intensity = 0;
            isOn=false;
        }

        else {
            lampLight.intensity = 1;
            isOn=true;
        }
    }
}

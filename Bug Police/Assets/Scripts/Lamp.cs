using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
     private bool isOn = true;

     [SerializeField]
     Light light;
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
            light.intensity = 0;
            isOn=false;
        }

        else {
            light.intensity = 1;
            isOn=true;
        }
    }
}

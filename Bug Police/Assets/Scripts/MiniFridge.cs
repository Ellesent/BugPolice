using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniFridge : MonoBehaviour
{
    // Track if the fridge is open or not
    private bool isOpen = false;

    [SerializeField]
    GameObject fridgeDoor;

    [SerializeField]
    Light fridgeLight;

    [SerializeField]
    float lightIntensity;
    // Start is called before the first frame update
    void Start()
    {
        fridgeLight.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detect mouse clicks on fridge
    void OnMouseDown()
    {
        // Open/Close fridge door depending on state
        // TODO Possibly move to a state machine
        if (isOpen) {
            fridgeDoor.transform.Rotate(new Vector3(0,90,0));
            fridgeLight.intensity = 0;
            isOpen=false;
        }

        else {
            fridgeDoor.transform.Rotate(new Vector3(0,-90,0));
            fridgeLight.intensity = lightIntensity;
            isOpen=true;
        }
    }
}

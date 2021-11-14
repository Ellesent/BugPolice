using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniFridge : MonoBehaviour
{
    // Track if the fridge is open or not
    private bool isOpen = false;

    [SerializeField]
    GameObject fridgeDoor;
    // Start is called before the first frame update
    void Start()
    {
        
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
            isOpen=false;
        }

        else {
            fridgeDoor.transform.Rotate(new Vector3(0,-90,0));
            isOpen=true;
        }

        Debug.Log("Fridge Clicked!");
    }
}

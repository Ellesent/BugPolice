using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nightstand : MonoBehaviour
{
       private bool isOpen = false;

       private float toMove = 0.5f;

    [SerializeField]
    GameObject drawer;
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
        Vector3 currDrawerPosition = drawer.transform.position;
        // Open/Close drawer in nightstand
        // TODO Possibly move to a state machine
        if (isOpen) {
            drawer.transform.position = new Vector3(currDrawerPosition.x,  currDrawerPosition.y, currDrawerPosition.z + toMove);
            isOpen=false;
        }

        else {
            drawer.transform.position = new Vector3(currDrawerPosition.x, currDrawerPosition.y, currDrawerPosition.z - toMove);
            isOpen=true;
        }
    }
}

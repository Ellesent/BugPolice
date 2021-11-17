using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampRope : MonoBehaviour
{
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();

        body.AddForce(new Vector3(15f,0,0), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    static int numCollected = 0;
    [SerializeField]
    BugFoundEvent bugFoundEvent;
    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        numCollected++;
        bugFoundEvent.Invoke(numCollected);
        GameObject.Destroy(gameObject);
    }
}

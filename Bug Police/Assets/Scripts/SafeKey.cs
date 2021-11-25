using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeKey : MonoBehaviour
{
    [SerializeField]
    int numKey;

    [SerializeField]
    SafeKeyPressedEvent safeKeyPressedEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        Debug.Log(numKey + " pressed!");
        safeKeyPressedEvent.Invoke(numKey);
    }
}

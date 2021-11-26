using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{

       private bool isOpen = false;
       private bool isUnlocked = false;

       private float toMove = 0.5f;

    [SerializeField]
    GameObject safeDoor;


    [SerializeField]
    GameObject upcloseSafeToSpawn;

    Vector3 spawnPosition;

    Vector3 safeSize;

    // Start is called before the first frame update
    void Start()
    {
       spawnPosition =  Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane));
       Transform safeParentTransform = upcloseSafeToSpawn.transform.Find("safe");
       Transform totalSafeTransform = safeParentTransform.Find("TotalSafe");
       safeSize = totalSafeTransform.GetComponent<MeshRenderer>().bounds.size;
       spawnPosition.y = spawnPosition.y - ((safeSize.y) * 0.75f); 
       spawnPosition.z  = spawnPosition.z + 1.75f;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Vector3 currDrawerPosition = safeDoor.transform.position;
        // Open/Close drawer in nightstand
        // TODO Possibly move to a state machine
        if (isUnlocked) {
            if (isOpen) {
            safeDoor.transform.Rotate(new Vector3(0,0, 90));
            }
            else {
                safeDoor.transform.Rotate(new Vector3(0,0, -90));

            }
            isOpen=!isOpen;
        }

        else {
            GameObject.Instantiate(upcloseSafeToSpawn, spawnPosition, upcloseSafeToSpawn.transform.rotation);
        }
    }
}

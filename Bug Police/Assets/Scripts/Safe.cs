using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{
     // variables used for blurring the background when the user looks at the safe
      //PostProcessVolume m_Volume;
     // DepthOfField depth;
       private bool isOpen = false;

       private float toMove = 0.5f;

    [SerializeField]
    GameObject safeDoor;

    [SerializeField]
    GameObject depthFieldBoxVolume;

    [SerializeField]
    GameObject upcloseSafeToSpawn;

    Vector3 spawnPosition;

    Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
       spawnPosition =  Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane));
       size = upcloseSafeToSpawn.GetComponent<BoxCollider>().size;
       spawnPosition.y = spawnPosition.y - size.y;
       spawnPosition.z  = spawnPosition.z + 1f;
       Debug.Log(spawnPosition);
        
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
        if (isOpen) {
            safeDoor.transform.Rotate(new Vector3(0,0, 90));
           depthFieldBoxVolume.SetActive(false);
           // drawer.transform.position = new Vector3(currDrawerPosition.x,  currDrawerPosition.y, currDrawerPosition.z + toMove);
            isOpen=false;
        }

        else {
            depthFieldBoxVolume.SetActive(true);
            safeDoor.transform.Rotate(new Vector3(0,0, -90));
            GameObject.Instantiate(upcloseSafeToSpawn, spawnPosition, upcloseSafeToSpawn.transform.rotation);
            isOpen=true;
        }
    }
}

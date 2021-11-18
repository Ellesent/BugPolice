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
    // Start is called before the first frame update
    void Start()
    {
        // create an instance of the depth of field effect
        //depth = ScriptableObject.CreateInstance<DepthOfField>();
        //depth.enabled.Override(true);
       // depth.focalLength.Override(1f);
        
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
           // RuntimeUtilities.DestroyVolume(m_Volume, true, false);
           // drawer.transform.position = new Vector3(currDrawerPosition.x,  currDrawerPosition.y, currDrawerPosition.z + toMove);
            isOpen=false;
        }

        else {
           // m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, depth);
            //drawer.transform.position = new Vector3(currDrawerPosition.x, currDrawerPosition.y, currDrawerPosition.z - toMove);
            isOpen=true;
        }
    }
}

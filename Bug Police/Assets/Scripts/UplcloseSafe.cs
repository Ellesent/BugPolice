using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UplcloseSafe : MonoBehaviour
{

    List<int> currCode;

    [SerializeField]
    GameObject backButton;

    [SerializeField]
    List<int> passCode;

    private GameObject bbInstantiate;
    // Start is called before the first frame update
    void Start()
    {
        currCode = new List<int>();
        GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
        bbInstantiate = GameObject.Instantiate(backButton, canvas.GetComponent<RectTransform>());
        bbInstantiate.GetComponent<Button>().onClick.AddListener(BackButtonClick);
    }

    public void BackButtonClick() {
        GameObject.Destroy(bbInstantiate);
       GameObject.Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSafeKeyClick(int key) {
        currCode.Add(key);

        if (currCode.Count == passCode.Count) {
            bool verification = true;
            // do passcode verification
           for (int i = 0; i < currCode.Count; i++) {
               if (currCode[i] != passCode[i]) {
                   verification = false;
                   break;
               }
           }

           // clear the contents of currCode if verification failed
           if (!verification) {
               currCode.Clear();
           }
          // else if verification passed, fire unity event that the safe is now unlocked
           else {
               Debug.Log("Safe unlocked");
           }


        }
    }
}

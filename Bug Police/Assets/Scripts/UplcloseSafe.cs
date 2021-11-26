using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UplcloseSafe : MonoBehaviour
{

    List<int> currCode;

    [SerializeField]
    GameObject backButton;

    [SerializeField]
    GameObject passCodeText;

    [SerializeField]
    List<int> passCode;

    SafeUnlockedEvent safeUnlockedEvent;

    private GameObject bbInstantiate; // back button used to exit out of upclose safe view
    // Start is called before the first frame update

    private GameObject passCodeTextInstantiate;

    private TMP_Text passCodeTextField;
    void Start()
    {
        safeUnlockedEvent = new SafeUnlockedEvent();
        safeUnlockedEvent.AddListener(GameObject.FindGameObjectWithTag("Safe").GetComponent<Safe>().UnlockSafe);
        currCode = new List<int>();
        GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
        bbInstantiate = GameObject.Instantiate(backButton, canvas.GetComponent<RectTransform>());
        passCodeTextInstantiate = GameObject.Instantiate(passCodeText, canvas.GetComponent<RectTransform>());

        passCodeTextField = passCodeTextInstantiate.GetComponent<TMP_Text>();
        
        bbInstantiate.GetComponent<Button>().onClick.AddListener(BackButtonClick);
    }

    public void BackButtonClick() {

        // destroy back button and upclose safe
        GameObject.Destroy(bbInstantiate);
        GameObject.Destroy(passCodeTextInstantiate);
       GameObject.Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WrongPasscode() {

        for (int i = 0; i < 3; i++) {
           yield return StartCoroutine(BlinkTextRed());
        }

        // clear text
        passCodeTextField.text = "";
    }

    IEnumerator BlinkTextRed() {
        Color origColor = passCodeTextField.color;

        passCodeTextField.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        passCodeTextField.color = origColor;

         yield return new WaitForSeconds(0.1f);
    }

    public void OnSafeKeyClick(int key) {
        currCode.Add(key);
        passCodeTextField.text += " " + key;

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

               // start coroutine of blinking red text for passcode
               StartCoroutine(WrongPasscode());
               

           }
          // else if verification passed, fire unity event that the safe is now unlocked
           else {
               Debug.Log("Safe unlocked");
               safeUnlockedEvent.Invoke();
               
               passCodeTextField.color = Color.green;

           }

        }
    }
}

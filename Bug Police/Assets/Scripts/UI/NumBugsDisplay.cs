using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NumBugsDisplay : MonoBehaviour
{
    TMP_Text text;
    string startingText = "Bugs Found: ";
    // Start is called before the first frame update
    void Start()
    {
      text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void BugCollectedListener(int currBugCount) {
        text.text = startingText + currBugCount.ToString();
    }
}

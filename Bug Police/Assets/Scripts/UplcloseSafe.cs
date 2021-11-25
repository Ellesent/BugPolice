using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UplcloseSafe : MonoBehaviour
{

    [SerializeField]
    GameObject backButton;

    private GameObject bbInstantiate;
    // Start is called before the first frame update
    void Start()
    {
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
}

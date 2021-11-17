using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimation : MonoBehaviour
{

    float inTime = 1f;

    [SerializeField]
    RectTransform titleOne;

    [SerializeField]
    RectTransform titleTwo;
    // Start is called before the first frame update
    void Start()
    {
        //transform = GetComponent<RectTransform>();
        StartCoroutine(FullMainMenuAnimation());
    }

    // Update is called once per frame
    void Update()
    {

    }

     private IEnumerator FullMainMenuAnimation() {
         yield return StartCoroutine(SlideInRoutine(new Vector2(0.5f, 0.5f)));
     }

    private IEnumerator SlideInRoutine(Vector2 AnchorOffsetPosition)
    {
        Vector2 origPos = titleOne.anchoredPosition;
        titleOne.anchorMin = new Vector2(0.5f, 0.7f);
        titleOne.anchorMax = new Vector2(0.5f, 0.7f);
        for (float t = 0.01f; t < inTime; t += Time.deltaTime)
        {
            titleOne.anchoredPosition = Vector2.Lerp(origPos, AnchorOffsetPosition, Mathf.Min(1, t / inTime));
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimation : MonoBehaviour
{

    float inTime = 0.8f;

    [SerializeField]
    RectTransform titleOne;

    [SerializeField]
    RectTransform titleTwo;

    [SerializeField]
    RectTransform titleThree;
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

    private IEnumerator FullMainMenuAnimation()
    {
        yield return StartCoroutine(SlideInRoutine(new Vector2(0.5f, 100), titleOne));
        yield return StartCoroutine(SlideInRoutine(new Vector2(0.5f, 0f), titleTwo));
        yield return StartCoroutine(SlideInRoutine(new Vector2(0.5f, -100f), titleThree));

    }

    private IEnumerator SlideInRoutine(Vector2 AnchorOffsetPosition, RectTransform item)
    {
        Vector2 origPos = item.anchoredPosition;
        for (float t = 0.01f; t < inTime; t += Time.deltaTime)
        {
            item.anchoredPosition = Vector2.Lerp(origPos, AnchorOffsetPosition, Mathf.Min(1, t / inTime));
            yield return null;
        }
    }
}

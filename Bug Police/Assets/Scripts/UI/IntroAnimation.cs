using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class IntroAnimation : MonoBehaviour
{
    float fadeOutTime = 2f;

    TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();

        StartCoroutine(waitFunction1());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waitFunction1()
    {
        yield return (StartCoroutine(FadeInOutText(text.text)));
        yield return StartCoroutine(FadeInOutText("Items like hidden cameras, spy microphones, and anything else that doesn't belong."));
        yield return StartCoroutine(FadeInOutText("You are..."));
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator FadeInOutText(string newText) {
        text.text = newText;
        yield return StartCoroutine(FadeInRoutine());
        yield return new WaitForSeconds(3); //Will wait for 3 seconds then run the code below
        yield return StartCoroutine(FadeOutRoutine());
    }
    private IEnumerator FadeOutRoutine()
    {

        Color originalColor = text.color;
        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }
    }

    private IEnumerator FadeInRoutine()
    {

        Color originalColor = text.color;
        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.white, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }
    }
}

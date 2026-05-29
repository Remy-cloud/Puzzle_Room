using UnityEngine;
using System.Collections;

public class LoseUIManager : MonoBehaviour
{
    public CanvasGroup losePanel;
    public float fadeDuration = 2f;

    public void ShowLoseScreen()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float t = 0f;

        while (t < fadeDuration)
        {
            t += Time.unscaledDeltaTime;
            losePanel.alpha = Mathf.Lerp(0, 1, t / fadeDuration);
            yield return null;
        }

        losePanel.alpha = 1;
    }
}

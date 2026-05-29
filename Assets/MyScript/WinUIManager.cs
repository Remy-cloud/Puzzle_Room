using UnityEngine;
using System.Collections;

public class WinUIManager : MonoBehaviour
{
    public CanvasGroup winPanel;
    public float fadeDuration = 2f;

    public void ShowWinScreen()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float t = 0f;

        while (t < fadeDuration)
        {
            t += Time.unscaledDeltaTime;
            winPanel.alpha = Mathf.Lerp(0, 1, t / fadeDuration);
            yield return null;
        }

        winPanel.alpha = 1;
    }
}

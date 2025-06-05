using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{
    public GameObject levelTextObj;       // Assign your UI text GameObject here
    public float displayTime = 1.5f;
    public float fadeDuration = 1.5f;

    private TextMeshProUGUI tmpText;      // Optional TMP support
    private Text uiText;                  // Optional legacy Text

    void Start()
    {
        if (levelTextObj != null)
        {
            // Try to get TMP or UI Text
            tmpText = levelTextObj.GetComponent<TextMeshProUGUI>();
            uiText = levelTextObj.GetComponent<Text>();
            StartCoroutine(ShowAndFadeLevelText());
        }
    }

    IEnumerator ShowAndFadeLevelText()
    {
        levelTextObj.SetActive(true);

        Color originalColor = GetCurrentColor();
        SetAlpha(1f);

        yield return new WaitForSeconds(displayTime);

        float timer = 0f;
        while (timer < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            SetAlpha(alpha);
            timer += Time.deltaTime;
            yield return null;
        }

        levelTextObj.SetActive(false);
    }

    Color GetCurrentColor()
    {
        if (tmpText != null)
            return tmpText.color;
        if (uiText != null)
            return uiText.color;
        return Color.white;
    }

    void SetAlpha(float alpha)
    {
        if (tmpText != null)
        {
            Color c = tmpText.color;
            c.a = alpha;
            tmpText.color = c;
        }
        if (uiText != null)
        {
            Color c = uiText.color;
            c.a = alpha;
            uiText.color = c;
        }
    }
}

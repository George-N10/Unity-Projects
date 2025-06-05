using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameOverUI;
    public GameObject retryButton;
    public GameObject retryLevel1Button;

    private int deathCount = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void PlayerDied()
    {
        deathCount++;

        gameOverUI.SetActive(true);

        if (deathCount == 1)
        {
            retryButton.SetActive(true);
            retryLevel1Button.SetActive(false);
        }
        else
        {
            retryButton.SetActive(false);
            retryLevel1Button.SetActive(true);
        }
    }

    public void RetryCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RetryLevel1()
    {
        SceneManager.LoadScene("SampleScene"); // Replace "Level1" with your first scene name
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit!");
    }
}

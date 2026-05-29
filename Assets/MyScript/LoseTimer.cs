using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseTimer : MonoBehaviour
{
    public float timeLimit = 180f;
    public LoseUIManager loseUI;
    public float restartDelay = 2f;

    private bool hasLost = false;

    void Update()
    {
        if (hasLost) return;

        timeLimit -= Time.deltaTime;

        if (timeLimit <= 0)
        {
            TriggerLose();
        }
    }

    void TriggerLose()
    {
        hasLost = true;

        Debug.Log("Game Over!");

        if (loseUI != null)
        {
            loseUI.ShowLoseScreen();
        }

        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Invoke("RestartGame", restartDelay);
    }

    void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}

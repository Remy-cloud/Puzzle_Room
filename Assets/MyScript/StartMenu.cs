using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject player;

    void Start()
    {
        // Show cursor and pause game
        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (player != null)
        {
            player.SetActive(false);
        }
    }

    public void PlayGame()
    {
        // Hide instructions
        instructionPanel.SetActive(false);

        // Resume game
        Time.timeScale = 1f;

        // Enable player
        if (player != null)
        {
            player.SetActive(true);
        }

        // Lock cursor for FPS
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

using UnityEngine;
using TMPro;

public class PuzzleManager : MonoBehaviour
{
    public int totalTasks = 5;
    public int completedTasks = 0;

    public TMP_Text progressText;
    public DoorController door;

    private bool hasWon = false;

    void Start()
    {
        UpdateUI();
    }

    public void CompleteStep()
    {
        // Prevent double-triggering win logic
        if (hasWon) return;

        completedTasks++;
        UpdateUI();

        if (completedTasks >= totalTasks)
        {
            hasWon = true;

            Debug.Log("Win!");

            // 1. Open the door FIRST
            if (door != null)
            {
                door.OpenDoor();
            }
            else
            {
                Debug.LogWarning("Door is not assigned in PuzzleManager!");
            }

            // 2. Show win UI AFTER
            WinUIManager win = FindObjectOfType<WinUIManager>();
            if (win != null)
            {
                win.ShowWinScreen();
            }
            else
            {
                Debug.LogWarning("WinUIManager not found in scene!");
            }
        }
    }

    void UpdateUI()
    {
        if (progressText != null)
        {
            progressText.text = "Puzzle Progress: " + completedTasks + " / " + totalTasks;
        }
    }
}

using UnityEngine;
using TMPro;

public class PuzzleManager : MonoBehaviour
{
    public int totalTasks = 5;
    public int completedTasks = 0;

    public TMP_Text progressText;
    public DoorController door;

    void Start()
    {
        UpdateUI();
    }

    public void CompleteStep()
    {
        completedTasks++;
        UpdateUI();

        if (completedTasks >= totalTasks)
        {
            Debug.Log("All puzzles completed!");
            door.OpenDoor();
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

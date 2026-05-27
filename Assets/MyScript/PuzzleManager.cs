using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public int totalTasks = 5;
    public int completedTasks = 0;

    public Text progressText;

    public DoorController door;

    public void CompleteStep()
    {
        completedTasks++;
        UpdateUI();

        if (completedTasks >= totalTasks)
        {
            door.OpenDoor();
        }
    }

    void UpdateUI()
    {
        progressText.text = "Puzzle Progress: " + completedTasks + " / " + totalTasks;
    }
}

using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isOpen = false;

    public void OpenDoor()
    {
        if (isOpen) return;

        isOpen = true;

        // Rotate door open
        transform.Rotate(0, 90, 0);

        Debug.Log("Door Opened!");
    }
}
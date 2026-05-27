using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string itemID; // e.g. "redBook", "blueBook", "lamp"

    public bool isHeld = false;

    public void Interact()
    {
        if (isHeld) return;

        PlayerItemHolder.instance.PickUpItem(this);
    }
}

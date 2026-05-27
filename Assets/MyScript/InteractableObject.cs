using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string itemID;

    public bool isHeld = false;

    public Quaternion originalRotation;

    void Start()
    {
        // Save correct rotation for placement
        originalRotation = transform.rotation;
    }

    public void Interact()
    {
        if (isHeld) return;

        PlayerItemHolder.instance.PickUpItem(this);
    }
}

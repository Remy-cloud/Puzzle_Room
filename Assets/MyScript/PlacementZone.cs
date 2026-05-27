using UnityEngine;

public class PlacementZone : MonoBehaviour
{
    public string requiredItemID;
    public bool isCompleted = false;

    public PuzzleManager puzzleManager;

    public void PlaceItem(InteractableObject item)
    {
        if (isCompleted) return;

        if (item.itemID == requiredItemID)
        {
            item.transform.SetParent(transform);
            item.transform.localPosition = Vector3.zero;

            // ✅ IMPORTANT FIX: restore original rotation
            item.transform.rotation = item.originalRotation;

            item.isHeld = false;

            Collider col = item.GetComponent<Collider>();
            if (col != null) col.enabled = false;

            isCompleted = true;

            if (puzzleManager != null)
            {
                puzzleManager.CompleteStep();
            }
        }
        else
        {
            Debug.Log("Wrong item placed!");
        }
    }
}

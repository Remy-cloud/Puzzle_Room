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
            item.transform.localRotation = Quaternion.identity;

            item.enabled = false;
            isCompleted = true;

            puzzleManager.CompleteStep();
        }
        else
        {
            Debug.Log("Wrong item placed!");
        }
    }
}

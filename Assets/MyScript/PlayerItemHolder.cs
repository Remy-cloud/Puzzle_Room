using UnityEngine;

public class PlayerItemHolder : MonoBehaviour
{
    public static PlayerItemHolder instance;

    public Transform holdPoint;
    public InteractableObject heldItem;

    public float interactDistance = 3f;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldItem == null)
            {
                TryPickup();
            }
            else
            {
                TryPlace();
            }
        }
    }

    void TryPickup()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            InteractableObject obj = hit.collider.GetComponent<InteractableObject>();

            if (obj != null)
            {
                PickUpItem(obj);
            }
        }
    }

    public void PickUpItem(InteractableObject item)
    {
        heldItem = item;
        item.isHeld = true;

        item.transform.SetParent(holdPoint);
        item.transform.localPosition = Vector3.zero;
        item.transform.localRotation = Quaternion.identity;

        Rigidbody rb = item.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }

    void TryPlace()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            PlacementZone zone = hit.collider.GetComponent<PlacementZone>();

            if (zone != null)
            {
                zone.PlaceItem(heldItem);
                heldItem = null;
            }
        }
    }
}

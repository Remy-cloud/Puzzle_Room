using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator anim;

    public void OpenDoor()
    {
        anim.SetTrigger("Open");
    }
}

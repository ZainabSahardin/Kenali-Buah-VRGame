using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemID;
    public bool inSlot;
    public Vector3 slotRotation = Vector3.zero;
    public Slot currentSlot;

    public string name;
    public string pronunciation;
}

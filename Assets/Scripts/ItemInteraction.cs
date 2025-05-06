using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public string itemName; // e.g., "Menorah", "Candle"
    public ScrollPopupManager popupManager;

    void OnMouseDown() // Replace with VR interaction if needed
    {
        popupManager.ShowPopup(itemName);
    }
}

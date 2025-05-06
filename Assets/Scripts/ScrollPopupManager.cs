using UnityEngine;

public class ScrollPopupManager : MonoBehaviour
{
    public GameObject[] scrollPopups; // Assign in Inspector

    public void ShowPopup(string itemName)
    {
        foreach (GameObject popup in scrollPopups)
        {
            popup.SetActive(popup.name.ToLower().Contains(itemName.ToLower()));
        }
    }

    public void HideAll()
    {
        foreach (GameObject popup in scrollPopups)
        {
            popup.SetActive(false);
        }
    }
}

using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    public void DisableCanvas()
    {
        Debug.Log("Disabling Canvas");
        canvas.SetActive(false);
    }
}

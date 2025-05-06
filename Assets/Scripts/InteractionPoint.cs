using UnityEngine;

public class InteractionPoint : MonoBehaviour
{
    [SerializeField] private GameObject particleFxPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered Interaction zone!");
            particleFxPrefab.SetActive(false);
        }    
    }
}

using UnityEngine;

public class Floater : MonoBehaviour
{
    public float floatSpeed = 2f;
    public float floatAmount = 0.2f;

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmount;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}

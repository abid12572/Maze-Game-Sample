using UnityEngine;

public class Cheese : MonoBehaviour
{
    public float floatHeight = 0.5f;
    public float floatSpeed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Make cheese float up and down
        float y = startPosition.y +
                  Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        transform.position = new Vector3(
            startPosition.x,
            y,
            startPosition.z
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something touched the cheese: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collected the cheese!");

            Destroy(gameObject);
        }
    }
}
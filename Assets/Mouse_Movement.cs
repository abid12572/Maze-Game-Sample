using UnityEngine;
using UnityEngine.InputSystem;

public class MouseMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector2 input = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            input.x = -1;

        if (Keyboard.current.sKey.isPressed)
            input.x = 1;

        if (Keyboard.current.aKey.isPressed)
            input.y = -1;

        if (Keyboard.current.dKey.isPressed)
            input.y = 1;

        Vector3 movement = new Vector3(input.x, 0f, input.y);

        rb.MovePosition(
            rb.position + movement * moveSpeed * Time.fixedDeltaTime
        );
    }
}
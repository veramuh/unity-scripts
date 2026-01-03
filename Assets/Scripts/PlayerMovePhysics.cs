using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovePhysics : MonoBehaviour
{
    // Player Movement with Rigidbody, Forces, Mass..
    public float speed = 3f;
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        // Debug.Log("move x: " + movementVector.x + " y: " + movementVector.y);
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(movementX * speed, 0f, movementY * speed);
    }
}

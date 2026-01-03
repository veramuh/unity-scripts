using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    // Player Movement without Physics
    public float moveSpeed = 10f;
    public float sprintSpeed = 15f;
    private float speed = 10f;
    private float movementX;
    private float movementY;

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
        // Debug.Log("move x: " + movementVector.x + " y: " + movementVector.y);
    }
    void OnSprint(InputValue sprintValue)
    {
        speed = sprintValue.isPressed ? sprintSpeed : moveSpeed;
    }

    void Update()
    {
        Vector3 movement = new Vector3(movementX, movementY, 0f);
        transform.position += speed * Time.deltaTime * movement;
        // Debug.Log("Speed" + speed);
    }
}

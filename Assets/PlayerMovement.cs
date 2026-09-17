using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Read WASD / Arrow Key Inputs
        float moveX = 0f;
        float moveZ = 0f;

        if (Keyboard.current.wKey.isPressed) moveZ += 1f;
        if (Keyboard.current.sKey.isPressed) moveZ -= 1f;
        if (Keyboard.current.dKey.isPressed) moveX += 1f;
        if (Keyboard.current.aKey.isPressed) moveX -= 1f;
       
        float currentYVelocity = GetComponent<Rigidbody>().linearVelocity.y;
        GetComponent<Rigidbody>().linearVelocity = new Vector3(moveX * moveSpeed, currentYVelocity, moveZ * moveSpeed);
        
        // Jump
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 5, 0);
        }
    }
}

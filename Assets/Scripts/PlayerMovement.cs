using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed
    private Rigidbody2D rb;
    public Animator anim;

    // Add a public variable to track the last direction button pressed
    public Vector2 lastDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        // Check for key presses and release
        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1f;
            lastDirection = Vector2.up; // Update the last direction
        }
        else if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1f;
            lastDirection = Vector2.down; // Update the last direction
        }

        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
            lastDirection = Vector2.right; // Update the last direction
        }
        else if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
            lastDirection = Vector2.left; // Update the last direction
        }

        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // Apply movement to the Rigidbody2D
        rb.velocity = moveDirection * moveSpeed;
    }
}

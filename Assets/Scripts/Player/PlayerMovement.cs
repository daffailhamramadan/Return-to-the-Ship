using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private PlayerInput playerInput;

    [SerializeField] private float speed;

    [SerializeField] private float jumpHeight;

    [SerializeField] private Transform groundCheck;

    [SerializeField] private LayerMask ground;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        playerInput = GetComponent<PlayerInput>();
    }

    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(playerInput.Horizontal * speed, rigidBody.velocity.y);

        if (playerInput.SpaceKeyDown() && Physics2D.OverlapCircle(groundCheck.position, 0.1f, ground))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpHeight);
        }
    }
}

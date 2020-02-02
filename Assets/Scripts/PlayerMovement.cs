using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator animator;

    private Vector2 lastMovement = Vector2.zero;

    public Vector2 direction = Vector2.down;

    // Update is called once per frame
    void Update()
    {
        // Input

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

        if (movement != Vector2.zero)
        {
            lastMovement = movement;

            direction = Mathf.Abs(movement.x) > Mathf.Abs(movement.y) ?
                movement.x > 0 ? Vector2.right : Vector2.left :
                movement.y > 0 ? Vector2.up : Vector2.down;
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        animator.SetFloat("LastHorizontal", lastMovement.x);
        animator.SetFloat("LastVertical", lastMovement.y);
    }

    private void FixedUpdate()
    {
        // Movement
        rb.velocity = new Vector2(movement.x, movement.y) * moveSpeed;
    }
}

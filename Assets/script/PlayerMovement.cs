using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private bool isJumping = false;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;


    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
        movePlayer(horizontalMovement);
        isJumping = false;
    }

    void movePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);

        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, 1000));
        }

        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }
}

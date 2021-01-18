using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpPower;

    private bool isJumping = false;
    private bool isGrounded;

    public Transform footleft;
    public Transform footRight;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;


    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapArea(footleft.position, footRight.position);

        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }
        movePlayer(horizontalMovement);
    }

    void movePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);

        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpPower));
            isJumping = false;

        }

        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }
}

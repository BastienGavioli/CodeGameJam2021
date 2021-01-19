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

    public Animator animator;
 


    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapArea(footleft.position, footRight.position);

        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;


        Debug.Log(horizontalMovement);

        float verticalMvt = Input.GetAxis("Vertical") * jumpPower * Time.deltaTime;
        Debug.Log(verticalMvt);
        if (verticalMvt > 0 && isGrounded)
        {
            isJumping = true;
        }
        /*if ((Input.GetButtonDown("Jump") && isGrounded) || Input.GetKeyDown(KeyCode.U))
        {
            isJumping = true;
            Debug.Log("OK 1");
        }*/
        movePlayer(horizontalMovement);

        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Speed", characterVelocity);
    }

    void movePlayer(float _horizontalMovement)
    {

        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        
        if (isJumping)
        {
            Debug.Log("OK 3");

            rb.AddForce(new Vector2(0f, jumpPower));
            isJumping = false;

        }
        Debug.Log("isGrounded = " + isGrounded);

        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }

    public void jumpHurt()
    {
        rb.AddForce(new Vector2(0f, jumpPower));
        Debug.Log("OK 5");

    }
}

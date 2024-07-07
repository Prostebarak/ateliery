using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    public float jumpForce = 5f;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        bool isSprinting = Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W);
        float speed = isSprinting ? sprintSpeed : walkSpeed;

        Vector3 velocity = movement * speed;
        Vector3 localVelocity = transform.TransformDirection(velocity);

        rb.velocity = new Vector3(localVelocity.x, rb.velocity.y, localVelocity.z);
    }

    void Jump()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundLayer, QueryTriggerInteraction.Ignore);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

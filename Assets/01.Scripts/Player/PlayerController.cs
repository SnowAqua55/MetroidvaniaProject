using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Collider2D _collider;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private float rayDistance = 0.05f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if (isGrounded())
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            Vector2 movedVelocity = new Vector2(horizontal * moveSpeed, _rb.velocity.y);
            _rb.velocity = movedVelocity;
        }
        else
        {
            float horizontal = Input.GetAxis("Horizontal");
            Vector2 movedVelocity = new Vector2(horizontal * moveSpeed, _rb.velocity.y);
            _rb.velocity = movedVelocity;
        }
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private bool isGrounded()
    {
        Vector2 rayOrigin = new Vector2(_collider.bounds.center.x, _collider.bounds.min.y);
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.down, rayDistance, LayerMask.GetMask("Ground"));
        
        if (hit == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
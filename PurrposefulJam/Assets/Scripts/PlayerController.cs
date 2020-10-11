using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 10f;

    public Rigidbody2D theRB;

    private bool isGrounded;
    public Transform groundPoint;
    public LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundPoint.position, 0.2f, whatIsGround);
        Movement();
        Jump();
    }

    private void Movement()
    {
        if (isGrounded)
        {
            theRB.velocity = new Vector2(speed * Input.GetAxis("Horizontal"), theRB.velocity.y);
        }
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            }
        }
    }
}

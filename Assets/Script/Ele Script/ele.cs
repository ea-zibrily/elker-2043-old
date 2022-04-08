using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ele : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float jumpH;
    [SerializeField] public bool isDirectionRight;
    Rigidbody2D rb;

    [SerializeField] public float radius;
    [SerializeField] public Transform groundChecker;
    [SerializeField] public LayerMask ifIsGround;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        print("Welcome to ELKER 2K43!");
    }

    // Update is called once per frame
    void Update()
    {
        eleJump();
    }
    private void FixedUpdate()
    {
        eleMovement();
    }
    void eleMovement()
    {
        float move;
        move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (move > 0 && !isDirectionRight)
        {
            transform.eulerAngles = Vector2.zero;
            isDirectionRight = true;
        }
        else if(move < 0 && isDirectionRight)
        {
            transform.eulerAngles = Vector2.up * 180;
            isDirectionRight = false;
        }
    }

    void eleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.velocity = Vector2.up * jumpH;
        }
    }
    bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundChecker.position, radius, ifIsGround);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundChecker.position, radius);
    }
    
}

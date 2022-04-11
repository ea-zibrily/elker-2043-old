using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ele : MonoBehaviour
{
    //EleMovement
    [SerializeField] public float speed;
    [SerializeField] public float jumpH;
    [SerializeField] public bool isDirectionRight;

    //EleAnimation
    string walkParameter = "walk";
    string idleParameter = "idle";
   
    //Grounded
    [SerializeField] public float radius;
    [SerializeField] public Transform groundChecker;
    [SerializeField] public LayerMask ifIsGround;

    //Gameobject Ref
     Rigidbody2D myRb;
     Animator myAnim;

    private void Awake()
    {
        myRb = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }
    void Start()
    {
        print("Welcome to ELKER 2K43!");
    }
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
        myRb.velocity = new Vector2(move * speed, myRb.velocity.y);

        if( move!= 0)
        {
            myAnim.SetTrigger(walkParameter);
        }
        else
        {
            myAnim.SetTrigger(idleParameter);
        }

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
            myRb.velocity = Vector2.up * jumpH;
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

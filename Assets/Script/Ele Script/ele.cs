using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ele : MonoBehaviour
{
    //EleMovement
    [SerializeField] public float speed;
    [SerializeField] public float jumpH;
    [SerializeField] public bool isDirectionRight, isJumping;

    //EleAnimation
    string walkParameter = "walk";
    string idleParameter = "idle";
    string jumpParameter = "jump";
    string landParameter = "land";

    //Grounded
    [SerializeField] public float radius;
    [SerializeField] public Transform groundChecker;
    [SerializeField] public LayerMask ifIsGround;

    //CodePanel
    [SerializeField] public GameObject codePanel;
    [SerializeField] public GameObject closedSafe;
    [SerializeField] public GameObject openedSafe;
    public static bool isSafeOpened = false;

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
        codePanel.SetActive(false);
        closedSafe.SetActive(true);
        openedSafe.SetActive(false);
    }
    void Update()
    {
        eleJump();
        openLockDoor();

        if (isSafeOpened)
        {
            codePanel.SetActive(false);
            closedSafe.SetActive(false);
            openedSafe.SetActive(true);
        }

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

        if (move != 0)
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
        else if (move < 0 && isDirectionRight)
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

        if (!isGrounded() && !isJumping)
        {
            myAnim.SetTrigger(jumpParameter);
            isJumping = true;
        }
        else if (isGrounded() && isJumping)
        {
            myAnim.SetTrigger(landParameter);
            isJumping = false;
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

    void openLockDoor()
    {
        if (Input.GetKeyDown(KeyCode.R) && !isSafeOpened)
        {
            codePanel.SetActive(true);
        }
    }

}

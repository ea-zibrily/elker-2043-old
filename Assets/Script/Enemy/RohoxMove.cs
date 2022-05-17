using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RohoxMove : MonoBehaviour
{
    //RohoxMovement
    public float rohoxSpeed;
    public bool isDirectionRight;


    //GroundChecker
    public Transform groundCheck;
    public float groundCheckradius;
    public LayerMask itsGround;

    void Start()
    {
        print("GOO ROHOXKUN");
    }

    void Update()
    {
        transform.Translate(Vector2.right * rohoxSpeed * Time.deltaTime);

        if (!ThisisGround())
        {
            if (isDirectionRight)
            {
                transform.eulerAngles = Vector2.up * 180;
                isDirectionRight = false;
            }
            else
            {
                transform.eulerAngles = Vector2.zero;
                isDirectionRight = true;
            }
        }
    }

    bool ThisisGround()
    {
        return Physics2D.OverlapCircle(groundCheck.position, groundCheckradius, itsGround);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckradius);
    }
}

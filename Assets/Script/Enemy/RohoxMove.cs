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

    //WallChecker
    public Transform wallCheck;
    public float wallCheckradius;
    public LayerMask itsWall;

    void Start()
    {
        print("GOO ROHOXKUN");
    }

    void Update()
    {
        transform.Translate(Vector2.left * rohoxSpeed * Time.deltaTime);

        if (!ThisisGround() || ThisisWall())
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
    
    bool ThisisWall()
    {
        return Physics2D.OverlapCircle(wallCheck.position, wallCheckradius, itsWall);
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckradius);
        Gizmos.DrawWireSphere(wallCheck.position, wallCheckradius);
    }
    
}

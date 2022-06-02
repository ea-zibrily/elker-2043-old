using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVMove : MonoBehaviour
{
    public float CCTVSpeed;
    public bool isFacingRight;

    public Transform thisFlyWall;
    public float thisFlyWallradius;
    public LayerMask ifFlyWall;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * CCTVSpeed * Time.deltaTime);

        if (ThisisFlyingWall())
        {
            if (isFacingRight)
            {
                transform.eulerAngles = Vector2.up * 180;
                isFacingRight = false;
            }
            else
            {
                transform.eulerAngles = Vector2.zero;
                isFacingRight = true;
            }
        }
    }

    bool ThisisFlyingWall()
    {
        return Physics2D.OverlapCircle(thisFlyWall.position, thisFlyWallradius, ifFlyWall);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(thisFlyWall.position, thisFlyWallradius);
    }
}

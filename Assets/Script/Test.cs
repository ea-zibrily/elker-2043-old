using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed;
    public bool isRight;

    Rigidbody2D myRb;

    void Awake()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        gooele();
    }

    void gooele()
    {
        float move;
        move = Input.GetAxisRaw("Horizontal");
        myRb.velocity = new Vector2(speed * move, myRb.velocity.y);

        if (move < 0 && isRight)
        {
            transform.eulerAngles = Vector2.up * 180;
            isRight = false;
        }
        else if (move > 0 && !isRight)
        {
            transform.eulerAngles = Vector2.zero;
            isRight = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ele : MonoBehaviour
{
    public float speed;
    public float jumpH;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        print("Anjay");
    }

    // Update is called once per frame
    void Update()
    {
        float move;
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        if (move > 0.01f)
        {
            transform.localScale = new Vector2(0.30855f, transform.localScale.y);
        }
        if (move < -0.01f)
        {
            transform.localScale = new Vector2(-0.30855f, transform.localScale.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpH*1);
            //rb.AddForce(Vector2.up * jumpH);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float ms = 0.5f, scaleX, jumpH;


	Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        scaleX = transform.localScale.x;
    }

    void LeftMove()
    {
    	transform.localScale = new Vector3 (-scaleX, transform.localScale.y, transform.localScale.z);
    	transform.Translate (Vector3.left*ms*Time.fixedDeltaTime, Space.Self);
    }

    void RightMove()
    {
    	transform.localScale = new Vector3 (scaleX, transform.localScale.y, transform.localScale.z);
    	transform.Translate (Vector3.right*ms*Time.fixedDeltaTime, Space.Self);
    }

    void Jump()
    {
    	rb = GetComponent<Rigidbody2D>();

    	if(Input.GetKeyDown(KeyCode.Space))
    	{
    		rb.velocity = Vector2.up * jumpH;
    	}
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey (KeyCode.LeftArrow)){
        	LeftMove();
        } else if(Input.GetKey (KeyCode.RightArrow)){
        	RightMove();
        }

        Jump();
    }
}

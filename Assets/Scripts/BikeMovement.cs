using UnityEngine;
using System.Collections;

public class BikeMovement : MonoBehaviour {

    public float acceleration = 80.0f;
    public float jumpForce = 800.0f;

    private bool onGround = false;

	// Use this for initialization
	void Start ()
    {
	    
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = true;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        rigidbody2D.AddForce(new Vector2(Input.GetAxis("Horizontal") * acceleration, 0));

        // Jump control
        if (Input.GetButtonDown("Jump") && onGround)
        {
            // Add upward force
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
            onGround = false;
        }
	}
}

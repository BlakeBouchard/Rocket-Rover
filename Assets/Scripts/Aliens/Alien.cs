using UnityEngine;
using System.Collections;

public class Alien : MonoBehaviour {

    public float minJumpForce = 2500.0f;
    public float maxJumpForce = 3300.0f;

    public float minForwardForce = 1100.0f;
    public float maxForwardForce = 1800.0f;

    public float killSpinForce = 50.0f;

    protected bool isActive = true;

    // private bool isActive = true;

	// Use this for initialization
	void Start()
    {
        Jump();
	}

    protected void Jump()
    {
        float jumpCoefficient = Random.Range(0.1f, 0.9f);
        float forwardForce = minForwardForce + ((maxForwardForce - minForwardForce) * jumpCoefficient);
        float jumpForce = minJumpForce + ((maxJumpForce - minJumpForce) * (1 - jumpCoefficient));

        // Debug.Log("Jump values for alien: Forward " + forwardForce + ", Jump " + jumpForce);

        rigidbody2D.AddForce(new Vector2(-forwardForce, jumpForce));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "PlayerProjectile")
        {
            BlewUp();
        }
        else if (collision.collider.tag == "Boundary")
        {
            Destroy(this.gameObject);
        }
    }

    /*
    public bool IsHarmful()
    {
        return isActive;
    }
    */

    protected void BlewUp()
    {
        SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();
        sprite.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        foreach (SpriteRenderer childSprite in this.GetComponentsInChildren<SpriteRenderer>())
        {
            childSprite.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        }
        rigidbody2D.AddTorque(killSpinForce);
        // isActive = false;
        collider2D.enabled = false;
        this.isActive = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

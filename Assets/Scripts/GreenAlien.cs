using UnityEngine;
using System.Collections;

public class GreenAlien : MonoBehaviour {

    public float jumpForce = 1000.0f;
    public float forwardForce = 100.0f;
    public float killSpinForce = 50.0f;

    // private bool isActive = true;

	// Use this for initialization
	void Start ()
    {
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

    private void BlewUp()
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
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

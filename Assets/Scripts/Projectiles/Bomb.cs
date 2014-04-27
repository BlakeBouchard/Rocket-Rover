using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    public float dragForce = 100.0f;

	// Use this for initialization
	void Start()
    {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        string colliderTag = collision.collider.tag;
        if (colliderTag == "Ground")
        {
            rigidbody2D.AddForce(new Vector2(-dragForce, 0));
        }
        else if (colliderTag == "Boundary")
        {
            Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}

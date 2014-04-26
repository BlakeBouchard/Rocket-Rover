using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start()
    {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        string colliderTag = collision.collider.tag;
        if (colliderTag == "Boundary" || colliderTag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
    
    // Update is called once per frame
	void Update()
    {
	
	}
}

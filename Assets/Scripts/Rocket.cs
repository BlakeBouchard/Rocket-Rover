using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	    
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Boundary")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Enemy")
        {
            // Explode();
        }
    }

    private void Explode()
    {
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

using UnityEngine;
using System.Collections;

public class GreenAlien : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "PlayerProjectile")
        {
            Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

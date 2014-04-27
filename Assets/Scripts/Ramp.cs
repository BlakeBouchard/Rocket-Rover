using UnityEngine;
using System.Collections;

public class Ramp : MonoBehaviour {

    public Transform cleanupPrefab;

    // Use this for initialization
	void Start()
    {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        string colliderTag = collision.collider.tag;
        if (colliderTag == "Boundary")
        {
            Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
        if (transform.position.x < cleanupPrefab.transform.position.x)
        {
            Destroy(this.gameObject);
        }
	}
}

using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    public Transform explosionPrefab;

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
        else if (collision.collider.tag == "Enemy" || collision.collider.tag == "Ground")
        {
            StartCoroutine("Explode");
        }
    }

    IEnumerator Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.001f);
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

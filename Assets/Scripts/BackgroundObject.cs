using UnityEngine;
using System.Collections;

public class BackgroundObject : MonoBehaviour {

    public float moveSpeed = 1.0f;

	// Use this for initialization
	void Start ()
    {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.Translate(-moveSpeed, 0, 0);
	}
}

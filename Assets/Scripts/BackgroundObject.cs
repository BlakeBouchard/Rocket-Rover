using UnityEngine;
using System.Collections;

public class BackgroundObject : MonoBehaviour {

    public float moveSpeed = 1.0f;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.Translate(-moveSpeed, 0, 0);
	}
}

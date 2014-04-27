using UnityEngine;
using System.Collections;

public class BackgroundObject : MonoBehaviour {

    public float moveSpeed = 1.0f;

    public Transform cleanupObject;

	// Use this for initialization
	void Start ()
    {
        if (!cleanupObject)
        {
            Debug.Log("No cleanup object assigned for: " + gameObject.name);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (this.transform.position.x < cleanupObject.transform.position.x)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.transform.Translate(-moveSpeed, 0, 0);
        }
	}
}

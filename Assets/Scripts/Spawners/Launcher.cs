using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

    public Transform rocketPrefab;
    public float rocketSpeed;

	// Use this for initialization
	void Start()
    {
        
	}
	
	// Update is called once per frame
	void Update()
    {
        if (Input.mousePresent)
        {
            Vector2 convertedMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            float mouseOffsetX = convertedMousePosition.x - transform.position.x;
            float mouseOffsetY = convertedMousePosition.y - transform.position.y;

            float angleToMouse = Mathf.Atan2(mouseOffsetY, mouseOffsetX);
            transform.eulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * angleToMouse);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Transform rocket = Instantiate(rocketPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), transform.rotation) as Transform;
            rocket.name = rocketPrefab.name;
            //rocket.parent = this.transform;
            float rocketAngle = transform.eulerAngles.z * Mathf.Deg2Rad;
            rocket.rigidbody2D.velocity = new Vector2(Mathf.Cos(rocketAngle) * rocketSpeed, Mathf.Sin(rocketAngle) * rocketSpeed);
        }
	}
}

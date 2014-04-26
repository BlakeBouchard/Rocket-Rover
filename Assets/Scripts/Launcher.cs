using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.mousePresent)
        {
            Vector2 convertedMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            float mouseOffsetX = convertedMousePosition.x - transform.position.x;
            float mouseOffsetY = convertedMousePosition.y - transform.position.y;

            float angleToMouse = Mathf.Atan2(mouseOffsetY, mouseOffsetX);
            Debug.Log("Angle to Mouse: " + angleToMouse);
            transform.eulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * angleToMouse);
        }
	}
}

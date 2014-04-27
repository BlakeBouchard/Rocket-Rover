using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float distanceTravelled = 0;
    GUIText distanceLabel;

    public float velocity = 40.0f;

	// Use this for initialization
	void Start()
    {
        this.distanceLabel = GameObject.Find("Distance Travelled").GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update()
    {
        distanceTravelled += velocity * Time.deltaTime;
        distanceLabel.text = "Distance Travelled: " + (int)distanceTravelled + " m";
	}
}

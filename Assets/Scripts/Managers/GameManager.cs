using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float distanceTravelled = 0;
    GUIText distanceLabel;

    public float velocity = 40.0f;

	// Use this for initialization
	void Start()
    {
        SetUpCollisionIgnores();
        this.distanceLabel = GameObject.Find("Distance Travelled").GetComponent<GUIText>();
	}

    private void SetUpCollisionIgnores()
    {
        Physics2D.IgnoreLayerCollision(8, 9); // Player and Player Projectiles
        Physics2D.IgnoreLayerCollision(10, 11); // Enemy and Ground
        Physics2D.IgnoreLayerCollision(11, 12); // Enemy and Enemy Projectile
    }
	
	// Update is called once per frame
	void Update()
    {
        distanceTravelled += velocity * Time.deltaTime;
        distanceLabel.text = "Distance Travelled: " + (int)distanceTravelled + " m";
	}
}

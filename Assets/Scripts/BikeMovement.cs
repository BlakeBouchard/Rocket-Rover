using UnityEngine;
using System.Collections;

public class BikeMovement : MonoBehaviour {

    public float acceleration = 80.0f;
    public float jumpForce = 800.0f;
    public float torque = -10.0f;

    private bool onGround = false;

    public float distanceTravelled = 0;
    GUIText distanceLabel;

    public float velocity = 40.0f;

    public Transform gameOverPrefab;
    public Transform explosionPrefab;

    public int highScore = 0;

	// Use this for initialization
	void Start()
    {
        this.distanceLabel = GameObject.Find("Distance Travelled").GetComponent<GUIText>();
        if (PlayerPrefs.HasKey("High Score"))
        {
            this.highScore = PlayerPrefs.GetInt("High Score");
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        string colliderTag = collision.collider.tag;

        if (colliderTag == "Ground")
        {
            onGround = true;
        }
        else if (colliderTag == "Enemy" || colliderTag == "EnemyProjectile")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Debug.Log("Player Exploded!");
            Instantiate(gameOverPrefab);
            GUIText blewUpGUI = GameObject.Find("You Blew Up").GetComponent<GUIText>();
            if ((int)distanceTravelled > highScore)
            {
                blewUpGUI.text = "New High Score! You roved " + (int)distanceTravelled + " metres!";
                PlayerPrefs.SetInt("High Score", (int)distanceTravelled);
            }
            else
            {
                blewUpGUI.text = "You got blown up by Mars aliens! Your high score is: " + highScore + " metres";
            }
            Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
        rigidbody2D.AddForce(new Vector2(Input.GetAxis("Horizontal") * acceleration, 0));

        distanceTravelled += velocity * Time.deltaTime;
        distanceLabel.text = "Distance Travelled: " + (int)distanceTravelled + " m";

        if (!onGround)
        {
            rigidbody2D.AddTorque(Input.GetAxis("Horizontal") * torque);
        }

        // Jump control
        if (Input.GetButtonDown("Jump") && onGround)
        {
            // Add upward force
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
            onGround = false;
        }
	}
}

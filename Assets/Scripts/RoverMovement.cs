using UnityEngine;
using System.Collections;

public class RoverMovement : MonoBehaviour {

    public float acceleration = 100.0f;
    public float jumpForce = 1800.0f;
    public float torque = -2.0f;

    private bool onGround = false;

    public Transform explosionPrefab;

    private GameManager gameManager;

	// Use this for initialization
	void Start()
    {
        this.gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
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
            Instantiate(explosionPrefab, collision.collider.transform.position, Quaternion.identity);
            gameManager.EndGame();
            Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
        rigidbody2D.AddForce(new Vector2(Input.GetAxis("Horizontal") * acceleration, 0));

        if (!onGround)
        {
            rigidbody2D.AddTorque(Input.GetAxis("Horizontal") * torque);
        }

        // Jump control
        if (Input.GetButtonDown("Jump") && onGround)
        {
            // Add upward force
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
            audio.Play();
            onGround = false;
        }
	}
}

using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        SetUpCollisionIgnores();
	}

    private void SetUpCollisionIgnores()
    {
        Physics2D.IgnoreLayerCollision(8, 9); // Player and Player Projectiles
        Physics2D.IgnoreLayerCollision(10, 11); // Enemy and Ground
        Physics2D.IgnoreLayerCollision(11, 12); // Enemy and Enemy Projectile
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

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
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

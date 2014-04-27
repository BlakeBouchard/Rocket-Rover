using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float distanceTravelled = 0;
    GUIText distanceLabel;

    public float velocity = 40.0f;
    public int highScore = 0;

    public Transform gameOverPrefab;

    private bool playerIsAlive = true;

	// Use this for initialization
	void Start()
    {
        if (PlayerPrefs.HasKey("High Score"))
        {
            this.highScore = PlayerPrefs.GetInt("High Score");
        }
        this.distanceLabel = GameObject.Find("Distance Travelled").GetComponent<GUIText>();
	}

    public void EndGame()
    {
        playerIsAlive = false;
        Transform gameOverGUI = Instantiate(gameOverPrefab) as Transform;
        GUIText blewUpGUI = gameOverGUI.FindChild("You Blew Up").GetComponent<GUIText>();
        if ((int)distanceTravelled > highScore)
        {
            blewUpGUI.text = "New High Score!\nYou roved " + (int)distanceTravelled + " metres!";
            PlayerPrefs.SetInt("High Score", (int)distanceTravelled);
        }
        else
        {
            blewUpGUI.text = "You got blown up by Mars aliens!\nYour high score is: " + highScore + " metres";
        }
    }
	
	// Update is called once per frame
	void Update()
    {
        if (playerIsAlive)
        {
            distanceTravelled += velocity * Time.deltaTime;
            distanceLabel.text = "Distance Travelled: " + (int)distanceTravelled + " m";
        }
	}
}

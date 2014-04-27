using UnityEngine;
using System.Collections;

public class ShowHighScore : MonoBehaviour {

	// Use this for initialization
	void Start()
    {
        GUIText highScoreGUI = GetComponent<GUIText>();
	    if (PlayerPrefs.HasKey("High Score"))
        {
            float highScore = PlayerPrefs.GetInt("High Score");
            highScoreGUI.text = "High Score: " + highScore + " m";
        }
	}
	
	// Update is called once per frame
	void Update()
    {
	    
	}
}

using UnityEngine;
using System.Collections;

public class ButtonListener : MonoBehaviour {

    public bool isQuitButton = false;
    public int levelToLoad = 1;

	// Use this for initialization
	void Start()
    {
	
	}

    void OnMouseDown()
    {
        if (isQuitButton)
        {
            Application.Quit();
        }
        else
        {
            Application.LoadLevel(levelToLoad);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}

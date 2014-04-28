using UnityEngine;
using System.Collections;

public class YellowAlien : Alien {

    public float timeUntilBombs = 0.5f;
    public float timeBetweenBombs = 1.0f;
    private int difficulty;

    public Transform yellowBombPrefab;

	// Use this for initialization
	void Start()
    {
        Jump();
        StartCoroutine("DropBombs");
        this.difficulty = GameObject.Find("Game Manager").GetComponent<GameManager>().difficulty;
	}

    IEnumerator DropBombs()
    {
        yield return new WaitForSeconds(timeUntilBombs);
        while (isActive)
        {
            Instantiate(yellowBombPrefab, new Vector3(transform.position.x, transform.position.y, 2), Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenBombs / Mathf.Sqrt(difficulty));
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}

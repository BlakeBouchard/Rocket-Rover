using UnityEngine;
using System.Collections;

public class GreenAlienSpawner : MonoBehaviour {

    public Transform greenAlienPrefab;

	// Use this for initialization
	void Start () {
        StartCoroutine("SpawnAlien");
	}

    IEnumerator SpawnAlien()
    {
        while (true) {
            yield return new WaitForSeconds(3.0f);
            Transform alien = Instantiate(greenAlienPrefab, transform.position, Quaternion.identity) as Transform;
            alien.name = greenAlienPrefab.name;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

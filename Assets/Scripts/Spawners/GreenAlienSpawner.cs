using UnityEngine;
using System.Collections;

public class GreenAlienSpawner : MonoBehaviour {

    public Transform greenAlienPrefab;

    public float baseSpawnTime = 3.0f;

	// Use this for initialization
	void Start () {
        StartCoroutine("SpawnAlien");
	}

    IEnumerator SpawnAlien()
    {
        while (true) {
            Transform alien = Instantiate(greenAlienPrefab, transform.position, Quaternion.identity) as Transform;
            alien.name = greenAlienPrefab.name;
            yield return new WaitForSeconds(baseSpawnTime);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class AlienSpawner : MonoBehaviour {

    public Transform alienPrefab;

    public float baseSpawnTime = 3.0f;

	// Use this for initialization
	void Start () {
        StartCoroutine("SpawnAlien");
	}

    IEnumerator SpawnAlien()
    {
        while (true) {
            yield return new WaitForSeconds(baseSpawnTime);
            Transform alien = Instantiate(alienPrefab, transform.position, Quaternion.identity) as Transform;
            alien.name = alienPrefab.name;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

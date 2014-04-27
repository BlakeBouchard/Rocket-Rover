using UnityEngine;
using System.Collections;

public class AlienSpawner : MonoBehaviour {

    public Transform alienPrefab;

    public float baseSpawnTime = 3.0f;
    public float warningTime = 1.0f;

    public Transform warningSignPrefab;

	// Use this for initialization
	void Start()
    {
        StartCoroutine("SpawnAlien");
	}

    IEnumerator SpawnAlien()
    {
        while (true) {
            yield return new WaitForSeconds(baseSpawnTime - warningTime);
            Transform warningSign = Instantiate(warningSignPrefab) as Transform;
            yield return new WaitForSeconds(warningTime);
            Transform alien = Instantiate(alienPrefab, transform.position, Quaternion.identity) as Transform;
            alien.name = alienPrefab.name;
            Destroy(warningSign.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}

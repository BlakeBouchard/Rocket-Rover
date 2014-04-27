using UnityEngine;
using System.Collections;

public class AlienSpawner : MonoBehaviour {

    public Transform alienPrefab;

    private int difficulty = 1;

    public float baseSpawnTime = 3.0f;
    public float spawnEntropy = 1.0f;
    public float warningTime = 1.0f;

    public Transform warningSignPrefab;

	// Use this for initialization
	void Start()
    {
        StartCoroutine("SpawnAlien");
	}

    void IncreaseDifficulty(int newDifficulty)
    {
        this.difficulty = newDifficulty;
        Debug.Log(name + " increased difficulty to " + this.difficulty);
    }

    IEnumerator SpawnAlien()
    {
        while (true) {
            float spawnTime = (baseSpawnTime + Random.Range(-spawnEntropy / 2, spawnEntropy / 2)) / Mathf.Sqrt(difficulty);
            Debug.Log(alienPrefab.name + " spawn time: " + spawnTime);
            yield return new WaitForSeconds(spawnTime - warningTime);
            Transform warningSign = Instantiate(warningSignPrefab) as Transform;
            yield return new WaitForSeconds(warningTime);
            Transform alien = Instantiate(alienPrefab, transform.position, Quaternion.identity) as Transform;
            alien.name = alienPrefab.name;
            alien.parent = this.transform;
            Destroy(warningSign.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}

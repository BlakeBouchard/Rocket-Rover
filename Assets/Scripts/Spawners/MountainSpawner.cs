using UnityEngine;
using System.Collections;

public class MountainSpawner : MonoBehaviour {

    public Transform[] mountainPrefabs;

    public float baseSpawnTime = 1.0f;
    public float spawnEntropy = 0.5f;

	// Use this for initialization
	void Start()
    {
        StartCoroutine("SpawnMountains");
	}

    IEnumerator SpawnMountains()
    {
        while (true)
        {
            float spawnTime = baseSpawnTime + Random.Range(-spawnEntropy / 2, spawnEntropy / 2);
            yield return new WaitForSeconds(spawnTime);
            int randomMountainNumber = Random.Range(0, mountainPrefabs.Length);
            Transform mountain = Instantiate(mountainPrefabs[randomMountainNumber], transform.position, Quaternion.identity) as Transform;
            mountain.name = mountainPrefabs[randomMountainNumber].name;
            mountain.parent = this.transform;
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}

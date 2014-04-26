using UnityEngine;
using System.Collections;

public class MountainSpawner : MonoBehaviour {

    public Transform[] mountainPrefabs;

    public float spawnSpeed = 1;

	// Use this for initialization
	void Start()
    {
        StartCoroutine("SpawnMountains");
	}

    IEnumerator SpawnMountains()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnSpeed);
            int randomMountainNumber = Random.Range(0, mountainPrefabs.Length);
            Instantiate(mountainPrefabs[randomMountainNumber], transform.position, Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}

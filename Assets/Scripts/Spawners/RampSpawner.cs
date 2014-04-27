using UnityEngine;
using System.Collections;

public class RampSpawner : MonoBehaviour {

    public Transform rampPrefab;

    private int difficulty = 1;
    public float rampSpeed = 10.0f;
    public float baseSpawnTime = 4.0f;
    public float spawnEntropy = 1.0f;

    public int highScore = 0;

	// Use this for initialization
	void Start()
    {
        StartCoroutine("SpawnRamp");
	}

    void IncreaseDifficulty(int newDifficulty)
    {
        this.difficulty = newDifficulty;
        Debug.Log(name + " increased difficulty to " + this.difficulty);
    }

    IEnumerator SpawnRamp()
    {
        while (true)
        {
            float spawnTime = (baseSpawnTime + Random.Range(-spawnEntropy / 2, spawnEntropy / 2)) / Mathf.Sqrt(difficulty);
            Debug.Log(rampPrefab.name + " spawn time: " + spawnTime);
            yield return new WaitForSeconds(spawnTime);
            Transform ramp = Instantiate(rampPrefab, transform.position, Quaternion.identity) as Transform;
            ramp.name = rampPrefab.name;
            ramp.parent = this.transform;
            ramp.rigidbody2D.velocity = new Vector3(-rampSpeed, 0, 0);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}

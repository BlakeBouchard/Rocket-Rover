﻿using UnityEngine;
using System.Collections;

public class RampSpawner : MonoBehaviour {

    public Transform rampPrefab;

    public float rampSpeed = 10.0f;
    public float baseSpawnTime = 4.0f;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine("SpawnRamp");
	}

    IEnumerator SpawnRamp()
    {
        while (true)
        {
            Transform ramp = Instantiate(rampPrefab, transform.position, Quaternion.identity) as Transform;
            ramp.name = rampPrefab.name;
            ramp.rigidbody2D.velocity = new Vector3(-rampSpeed, 0, 0);
            yield return new WaitForSeconds(baseSpawnTime);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    private float nextSpawn = 0;
	public Transform prefavToSpawn;
	public float spawnRate = 2;
	public float randomDelay = 3;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
        	Instantiate(prefavToSpawn,transform.position,Quaternion.identity);
        	nextSpawn = Time.time + spawnRate + Random.Range(0,randomDelay);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
	//cactus spawner
	//use the cactus spawner too to create the money and bad red
	private float nextSpawn = 0;
	public Transform prefabMoneySpawn;
	public Transform prefabRedSpawn;
	public Transform prefabFlatform;

	public float spawnRate = 1;
	public float randomDelay = 3;

	int pushMoney;
	int randPush;

    // Update is called once per frame
    void Update()
    {
    	//Debug.Log(Random.Range(0,2));
    	pushMoney = Random.Range(0,3);

        //if game start then push
        if(Time.time > nextSpawn && ButtonControl.gameStart)
        {
        	switch(pushMoney)
        	{
        		case 0:
        			Instantiate(prefabMoneySpawn,transform.position,Quaternion.identity);
        			break;
        		case 1:
        			Instantiate(prefabRedSpawn,transform.position,Quaternion.identity);
        			break;
        		case 2:
        			Instantiate(prefabFlatform,transform.position,Quaternion.identity);
        			break;
        		default:
        			Debug.Log("cactusSpawner::noOnePush");
        			break;
        	}

        	nextSpawn = Time.time + spawnRate + Random.Range(0,randomDelay);
        }
    }
}

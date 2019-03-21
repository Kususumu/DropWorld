using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [Range(0,100)]
	static public float speed = 8;

	//if the prefab is flatform
	public Transform prefabFlatform;
    
    // Update is called once per frame
    void Update()
    {
    	if(prefabFlatform.name == "platform(Clone)")
    	{
        	transform.position += Vector3.up *speed * Time.deltaTime;
    	}	
    }
}

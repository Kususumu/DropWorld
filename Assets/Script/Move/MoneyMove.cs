using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMove : MonoBehaviour
{
    [Range(0,10)]
	static public float speed = 9;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up *speed * Time.deltaTime;
    }
}

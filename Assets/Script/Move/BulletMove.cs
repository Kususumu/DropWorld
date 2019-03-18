using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

	[Range(0,20)]
	public float speed;

	public Rigidbody2D rb;

	private bool isRightInside;
	
	private bool isBulletDown;

	void Start()
	{
		isRightInside = JerryControl.isRight;
	}	

    // Update is called once per frame
    void Update()
    {
    	isBulletDown = JerryMoney.isBulletDown;

    	//Debug.Log("bulletMove::isBulletDown"+isBulletDown);
    	if(isRightInside && !isBulletDown)
    	{
        	rb.velocity = transform.right * speed;
        	rb.velocity = rb.velocity + new Vector2(0, -1) * speed;
    	}

    	else if(!isRightInside && !isBulletDown)
    	{
    		rb.velocity = -transform.right * speed;
    		rb.velocity = rb.velocity + new Vector2(0, -1) * speed;
    		//rb.velocity = transform.down *speed;
    	}

    	else
    	{
    		// the speed is too quick so 0.5
    		rb.velocity = rb.velocity + new Vector2(0, -1) * speed * 0.2f;	
    	}
    }
}

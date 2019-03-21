using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    //We canot Save live things in prefab
    //So its a problem in it
    //In order To Control the bullet Move
    //public Joystick joyStickBullet;

    //We read the buffer from jorryControl.joystick
    private float bulletHorizontal;
    private float bulletVertical;

    //Fire Delta::Decesion when to shoot or not
    private float fireDelta = 0.3f;

    [Range(0,20)]
	public float speed;

	public Rigidbody2D rb;

	//private bool isRightInside;
	
	private bool isBulletDown;

	void Start()
	{
        //isRightInside = BulletDriection
        bulletHorizontal = BulletDriection.BuDirecHori;
        bulletVertical = BulletDriection.BuDirecVerti;
        //Debug.Log("BulletDirection::Hori::"+BulletDriection.BuDirecHori);
        //Debug.Log("BulletDirection::Verti::"+BulletDriection.BuDirecVerti);
	}	

    // Update is called once per frame
    void Update()
    {
        
        //isBulletDown = JerryMoney.isBulletDown;

        ////Debug.Log("bulletMove::isBulletDown"+isBulletDown);
        //if(isRightInside && !isBulletDown)
        //{
        //  rb.velocity = transform.right * speed;
        //  rb.velocity = rb.velocity + new Vector2(0, -1) * speed;
        //}

        //else if(!isRightInside && !isBulletDown)
        //{
        //	rb.velocity = -transform.right * speed;
        //	rb.velocity = rb.velocity + new Vector2(0, -1) * speed;
        //	//rb.velocity = transform.down *speed;
        //}

        //else
        //{
        //	// the speed is too quick so 0.5
        //	rb.velocity = rb.velocity + new Vector2(0, -1) * speed * 0.2f;	
        //}

        if (!(bulletHorizontal < fireDelta && bulletHorizontal > -fireDelta) || !(bulletVertical < fireDelta && bulletVertical > -fireDelta))
        {
            //Please see - 
            //Two Time Faster
            rb.velocity = (new Vector2(1, 0) * bulletHorizontal + new Vector2(0, 1) * bulletVertical) * speed * 2;
            //Debug.Log("BulletMove::Horizontal" + bulletHorizontal);
            //Debug.Log("BulletMove::Vertical" + bulletVertical);
        }

        else
        {
            Destroy(gameObject);
        }

    }
}

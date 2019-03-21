using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryControl : MonoBehaviour
{
    static public bool isPhone = true;
    //static public bool isPhone = false;

	private Rigidbody2D myRigidBody;

    //input Joystick
    public Joystick joystick;
    //the joyStick cant be two,so it cause a lot of questions
    //we made two other static public float in order to save horizontal and vertical
    static public float joyHori;
    static public float joyVerti;


    //add a scrol to control range of jumpsDelta
    [Range(100,500)]
	public float jumpsDelta;

	//Animator
	private Animator myAnim;
	
	[Range(0,100)]
	public float moveSpeed;

    //Add A component to judge isRight
    //Control the 
    //jerryBullet:isRightInside
	static public bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //!isPhone
     	if(Input.GetKey(KeyCode.A) && !isPhone)
     	{
     		transform.Translate(Vector3.left * moveSpeed *Time.deltaTime);

     		myAnim.SetBool("isRight",false);
     		isRight=false;
     	}

     	if(Input.GetKey(KeyCode.D) && !isPhone)
     	{
     		transform.Translate(Vector3.right * moveSpeed *Time.deltaTime);
     		
     		myAnim.SetBool("isRight",true);
     		isRight=true;
     	}

     	if(Input.GetKey(KeyCode.W)&& !isPhone)
     	{
     		transform.Translate(Vector3.up * moveSpeed *Time.deltaTime);
     	}

     	if(Input.GetKey(KeyCode.S) && !isPhone)
     	{
     		transform.Translate(Vector3.down * moveSpeed *Time.deltaTime);
     	}

        //isPhone
        if (isPhone)
        {
            //Each update we save the two number use for Weapon
            joyHori = joystick.Horizontal;
            joyVerti = joystick.Vertical;

            //joystick left < 0
            if(joystick.Horizontal < 0)
            {
                myAnim.SetBool("isRight", false);

                //use is Right to judge the joystick.Vertical == 0 
                isRight = false;
                //Debug.Log("JerryControl::" + joystick.Horizontal);
            }

            else if(joystick.Horizontal == 0)
            {
                if(isRight)
                {
                    myAnim.SetBool("isRight", true);
                }

                else
                {
                    myAnim.SetBool("isRight", false);
                }
            }

            else
            {
                myAnim.SetBool("isRight", true);
                isRight = true;
                //Debug.Log("JerryControl::" + joystick.Horizontal);
            }

            //Horizontal
            transform.Translate(Vector3.right * joystick.Horizontal * moveSpeed * Time.deltaTime);

            //Vertical
            transform.Translate(Vector3.up * joystick.Vertical * moveSpeed * Time.deltaTime);
        }

        myAnim.SetFloat("vVelocity",Mathf.Abs(myRigidBody.velocity.y));
    }
}

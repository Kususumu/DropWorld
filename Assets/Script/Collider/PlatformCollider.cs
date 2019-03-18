using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollider : MonoBehaviour
{
    [Range(0, 1)]
    public float redTimeDelta = 0.07f;

    public float iceTimeDelta = 0.1f;

    private int cutTime;

	private SpriteRenderer sr;
	
    //Still plus the Timer into Collider
    private double redTimer = 0;

    private double iceTimer = 0;

    void Start()
	{
		cutTime = 0;

		sr = gameObject.GetComponent<SpriteRenderer>();
	}

    void Update()
    {
        if(cutTime == 1)
        {
            redTimer = redTimer + redTimeDelta;    
        }

        if(redTimer > 5)
        {
            //Do not GameOver Now
            

            //destroy the hero
            Destroy(gameObject);
        }

        if (cutTime == 2)
        {
            iceTimer = iceTimer + iceTimeDelta;
        }

        if(iceTimer > 1)
        {
            if (HeroState.isAlive)
            {
                if (GameObject.Find("--Canvas--") != null)
                {
                    //Debug.Log("jerryMoney::find --Canvas--");
                    //Debug.Log("jerryMoney::--Canvas--");
                    GameObject t = GameObject.Find("--Canvas--");

                    //use transform to find active = false child 
                    t.transform.Find("Frozen").gameObject.SetActive(true);
                }

                //slow the speed
                HeroState.setMoveSpeed(7.0f);
            }
            
            if(iceTimer >6)
            {
                if (HeroState.isAlive)
                {
                    if (GameObject.Find("--Canvas--") != null)
                    {
                        //Debug.Log("jerryMoney::find --Canvas--");
                        //Debug.Log("jerryMoney::--Canvas--");
                        GameObject t = GameObject.Find("--Canvas--");

                        //use transform to find active = false child 
                        t.transform.Find("Frozen").gameObject.SetActive(false);
                    }
                }

                //return the speed
                HeroState.setMoveSpeed(9.0f);

                //destroy the hero
                Destroy(gameObject);

            }

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.name == "bullet(Clone)")
    	{
    		cutTime++;

    		//due to cutTime change the color
    		if(cutTime == 1)
    		{
    			sr.color = new Color(1.0f,0.5f,0.5f,1.0f);
                gameObject.transform.localScale = 2 * gameObject.transform.localScale;
            }

    		if(cutTime == 2)
    		{
				sr.color = new Color(0.5f,1.0f,1.0f,1.0f);
            }

    		if(cutTime >= 3)
    		{
                if (HeroState.isAlive)
                {
                    if (GameObject.Find("--Canvas--") != null)
                    {
                        //Debug.Log("jerryMoney::find --Canvas--");
                        //Debug.Log("jerryMoney::--Canvas--");
                        GameObject t = GameObject.Find("--Canvas--");

                        //use transform to find active = false child 
                        t.transform.Find("Frozen").gameObject.SetActive(false);
                    }
                }

                //return the speed
                HeroState.setMoveSpeed(9.0f);

                JerryMoney.isBulletDown = false;
    			Destroy(gameObject);
    			//control the bullet
    			
    		}
    	}

        if(other.name == "DestroyerUp")
        {
            if (cutTime == 2)
            {
                sr.color = new Color(0.5f, 1.0f, 1.0f, 1.0f);

                if (HeroState.isAlive)
                {
                    if (GameObject.Find("--Canvas--") != null)
                    {
                        //Debug.Log("jerryMoney::find --Canvas--");
                        //Debug.Log("jerryMoney::--Canvas--");
                        GameObject t = GameObject.Find("--Canvas--");

                        //use transform to find active = false child 
                        t.transform.Find("Frozen").gameObject.SetActive(false);
                    }
                }

                //return the speed
                HeroState.setMoveSpeed(9.0f);
            }
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "blueJerry")
        {
            //cutTime==1  ->Red
            if (cutTime == 1)
            {
                //Debug.Log("PlatformCollider::RedColliderGameOver");

                if (HeroState.isAlive)
                {
                    if (GameObject.Find("--Canvas--") != null)
                    {
                        //Debug.Log("jerryMoney::find --Canvas--");
                        //Debug.Log("jerryMoney::--Canvas--");
                        GameObject t = GameObject.Find("--Canvas--");

                        //use transform to find active = false child 
                        t.transform.Find("GameOver").gameObject.SetActive(true);
                    }
                }
            }
                
        }
    }
}

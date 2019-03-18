using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryMoney : MonoBehaviour
{

	//to Control the bullet down
	public static bool isBulletDown;

	void Start()
	{
		isBulletDown = false;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
    	//Debug.Log("jerryMoneyProblem");
    	if(other.name == "money(Clone)")
    	{
    		//Debug.Log("jerryMoney::other.name");
    		MoneyState.moneyStore++;
    		//Debug.Log("jerryMoney::moneyState:"+moneyState.moneyStore);
    		//Debug.Log("jerryMoney::onTriggerEnter");
    		//
    		MoneyState.continuesGet++;
    		
    		Destroy(other.gameObject);
    	}

    	if(other.name == "redBad(Clone)")
    	{
    		//Go to heroState::GameOver
    		if(HeroState.isAlive)
    		{
    			if(GameObject.Find("--Canvas--") != null)
    			{
    				//Debug.Log("jerryMoney::find --Canvas--");
    				//Debug.Log("jerryMoney::--Canvas--");
    				GameObject t = GameObject.Find("--Canvas--");

    				//use transform to find active = false child 
    				t.transform.Find("GameOver").gameObject.SetActive(true);
       			}	
    		}

    		//Destroy self and redbad
    		Destroy(gameObject);
    		Destroy(other.gameObject);
    	}

    	
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if(col.transform.name == "platform(Clone)")
    	{
    		//method::delete a script 
    		//GameObject.Find("Cube").GetComponent<myscript>()
    		//if get touch ,to stop!
    		col.transform.GetComponent<PlatformMove>().enabled = false;

    		//make the hero bullet down
    		isBulletDown = true;
    	}
    }

    void OnCollisionExit2D(Collision2D col)
    {
    	isBulletDown = false;
    }
}

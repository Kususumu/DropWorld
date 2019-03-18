using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.name == "money(Clone)")
    	{
  			//Debug.Log("bulletCollider::moneyCollide");
    		MoneyState.moneyStore++;
    		Destroy(other.gameObject);
    	}

    	if(other.name == "redBad(Clone)")
    	{
    		MoneyState.moneyStore = MoneyState.moneyStore + 2;
			Destroy(other.gameObject);
    	}

    	if(other.name == "flatform(Clone)")
    	{
    		
    	}
    }
}

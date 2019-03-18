using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThings : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.name == "platform(Clone)")
    	{
    		MoneyState.destroyPlatformNumber++;
    		Destroy(other.gameObject);
    	}

    	if(other.name == "money(Clone)")
    	{
    		MoneyState.continuesGet = 1;
    		MoneyState.moneyStore = MoneyState.moneyStore + MoneyState.continuesGet;
    		Destroy(other.gameObject);
    	}

    	if(other.name == "redBad(Clone)")
    	{
    		MoneyState.destroyPlatformNumber--;
    		MoneyState.continuesGet = MoneyState.continuesGet - 29;
			Destroy(other.gameObject);
    	}

    	if(other.name == "bullet(Clone)")
    	{
    		Destroy(other.gameObject);
    	}


    }
}

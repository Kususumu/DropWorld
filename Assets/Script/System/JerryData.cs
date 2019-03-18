using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JerryData
{
	//four important number could be see in MoneyState
   	public int moneyStore;

    public int destroyPlatformNumber;

    public int continuesGet;

    public int goldFinal;

    public JerryData(MoneyState money)
    {
    	moneyStore = MoneyState.moneyStore;

    	destroyPlatformNumber = MoneyState.destroyPlatformNumber;

    	continuesGet = MoneyState.continuesGet;

    	goldFinal = MoneyState.goldFinal;

    }
}

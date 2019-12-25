using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroState : MonoBehaviour
{
    //Use heroState to Judge:
    //Alive,WeaponUse,BuildingPurchasing
    static public bool isAlive;
	public GameObject gameOver;

    public float allMoveSpeed;

    static public int weaponUse;
    static public int buildingNow;

	void Start()
	{
        //Inis
        allMoveSpeed = MoneyMove.speed;

		//When hero first created,he is alive.
		isAlive = true;

        //Inisualize
        weaponUse = 0;
        buildingNow = 0;
	}
    
    static public void setMoveSpeed(float s)
    {
        MoneyMove.speed = s;
        PlatformMove.speed = s;
    }

    public void GameOver()
    {
    	isAlive = false;
    	gameOver.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroState : MonoBehaviour
{

	static public bool isAlive;
	public GameObject gameOver;

    public float allMoveSpeed;

	void Start()
	{
        //Inis
        allMoveSpeed = MoneyMove.speed;

		//When hero first created,he is alive.
		isAlive = true;
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

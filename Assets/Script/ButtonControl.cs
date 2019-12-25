using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    static public bool gameStart;

    void Start()
    {
        gameStart = false;
    }

    public void startGame()
    {
        if(GameObject.Find("--Canvas--") != null)
        {
            //Debug.Log("jerryMoney::find --Canvas--");
            //Debug.Log("jerryMoney::--Canvas--");
            GameObject t = GameObject.Find("--Canvas--");

            //use transform to find active = false child 
            t.transform.Find("StartGame").gameObject.SetActive(false);
        }

        gameStart = true;
    }

    public void gameHelp()
    {
        if(GameObject.Find("--Canvas--") != null)
        {
            //Debug.Log("jerryMoney::find --Canvas--");
            //Debug.Log("jerryMoney::--Canvas--");
            GameObject t = GameObject.Find("--Canvas--");

            //use transform to find active = false child 
            t.transform.Find("Email").gameObject.SetActive(true);
        }
    }

    public void backToMenu()
    {
        if(GameObject.Find("--Canvas--") != null)
        {
            //Debug.Log("jerryMoney::find --Canvas--");
            //Debug.Log("jerryMoney::--Canvas--");
            GameObject t = GameObject.Find("--Canvas--");

            //use transform to find active = false child 
            t.transform.Find("Email").gameObject.SetActive(false);
        }
    }

    public void restartGame()
    {
    	SceneManager.LoadScene(0);

    	//delete the GameOver
    	//GameObject t = GameObject.Find("--Canvas--");
		//t.transform.Find("GameOver").gameObject.SetActive(false);
    }

    public void saveGame()
    {
        MoneyState.SaveGame();
    }

    public void loadGame()
    {
        MoneyState.LoadGame();
    }

    public void buyBuilding()
    {
        HeroState.buildingNow++;
        //Debug.Log("ButtonControl::buyBuilding:"+HeroState.buildingNow);
    }

    //still need to do better
    public void cancelBuilding()
    {
        HeroState.buildingNow--;
        //Debug.Log("ButtonControl::buyBuilding:" + HeroState.buildingNow);
    }

}

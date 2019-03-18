using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyState : MonoBehaviour
{
    static public int moneyStore;

    public TextMeshProUGUI Money;

    //use a platform number to faster the gold get
    static public int destroyPlatformNumber;

    //continues get the money
    static public int continuesGet;

    //Final
    static public int goldFinal;

    // Start is called before the first frame update
    void Start()
    {
        moneyStore = 0;
        
        destroyPlatformNumber = 1;

        continuesGet = 1;

        goldFinal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Money.text = "GOLD : " + calculateGold().ToString();
        
        //Debug.Log("MoneyState::moneyState:" + moneyStore);
        
    }

    public int calculateGold()
    {
        goldFinal= moneyStore * destroyPlatformNumber;

        return goldFinal;
    }

    static public void SaveGame()
    {
        //
        Debug.Log("MoneyState::StillHasProblem In SaveGame");
        //
        MoneyState t = new MoneyState();

        SaveSystem.SaveGame(t);


    }

    static public void LoadGame()
    {
        JerryData data = SaveSystem.LoadGame();

        moneyStore = data.moneyStore;

        destroyPlatformNumber = data.destroyPlatformNumber;

        continuesGet = data.continuesGet;

        goldFinal = data.goldFinal;
    }   
}

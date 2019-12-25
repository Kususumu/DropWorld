using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    //Every Player has its own building
    private int buildingNow;

    private void Start()
    {
        buildingNow = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Get Hero building
        if(buildingNow != HeroState.buildingNow)
        {
            buildingNow = HeroState.buildingNow;

            //ChangeBuilding
            building(buildingNow);
        }

        //if Equal do nothing
        else
        {
            
        }
    }

    private void building(int build)
    {
        //cancel the building now
        switch (build)
        {
            case 0:
                originalBuilding();
                break;
            case 1:
                groundBuilding();
                break;
            case 2:
                firstBuilding();
                break;
            default:
                //Debug.Log("BuildingSystem::default");
                HeroState.buildingNow = 0;
                break;
        }
    }

    private void originalBuilding()
    {
        if (GameObject.Find("--Construction--") != null)
        {
            //Debug.Log("jerryMoney::find --Canvas--");
            //Debug.Log("jerryMoney::--Canvas--");
            GameObject t = GameObject.Find("--Construction--");

            //use transform to find active = false child 
            t.transform.Find("BlueBuilding").gameObject.SetActive(true);
            t.transform.Find("GroundBuilding").gameObject.SetActive(false);
            t.transform.Find("FirstBuilding").gameObject.SetActive(false);
        }
    }

    private void groundBuilding()
    {
        if (GameObject.Find("--Construction--") != null)
        {
            //Debug.Log("jerryMoney::find --Canvas--");
            //Debug.Log("jerryMoney::--Canvas--");
            GameObject t = GameObject.Find("--Construction--");

            //use transform to find active = false child 
            t.transform.Find("BlueBuilding").gameObject.SetActive(false);
            t.transform.Find("GroundBuilding").gameObject.SetActive(true);
            t.transform.Find("FirstBuilding").gameObject.SetActive(false);
        }
    }

    private void firstBuilding()
    {
        if (GameObject.Find("--Construction--") != null)
        {
            //Debug.Log("jerryMoney::find --Canvas--");
            //Debug.Log("jerryMoney::--Canvas--");
            GameObject t = GameObject.Find("--Construction--");

            //use transform to find active = false child 
            t.transform.Find("BlueBuilding").gameObject.SetActive(false);
            t.transform.Find("GroundBuilding").gameObject.SetActive(false);
            t.transform.Find("FirstBuilding").gameObject.SetActive(true);
        }
    }
}

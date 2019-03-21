using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunReady : MonoBehaviour
{
    public Transform gunTrans;

    private bool isGunRight;

    private void Start()
    {
        isGunRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        //original x = 0.7 y = -0.5

        //GunMove
        gameObject.transform.position = gunTrans.position + new Vector3(0.0f, -1.0f, 0.0f);

        if (JerryControl.isRight)
        {
            
            if (!isGunRight)
            {          
                float t = gameObject.transform.localScale.x;
                Vector3 t3 = gameObject.transform.localScale;
                t3.x = -t;
                gameObject.transform.localScale = t3;
               
                isGunRight = true;
            }
        }

        else
        {
            if (isGunRight)
            {
                float t = gameObject.transform.localScale.x;
                Vector3 t3 = gameObject.transform.localScale;
                t3.x = -t;
                gameObject.transform.localScale = t3;

                isGunRight = false;
            }

        }

    }
}

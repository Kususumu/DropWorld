using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDriection : MonoBehaviour
{
    public Transform fireButton;

    //to Record the bullet direction
    static public float BuDirecHori;
    static public float BuDirecVerti;

    private Vector2 touchMiddle = new Vector2(2.8f, -5.6f);
    //only calculate divide by 2 is enough
    private Vector2 touchDelta = new Vector2(3.6f, 4.0f) /2 ;
    
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);

            //So it record the Direction the bullet should be SHOOT
            if(touchPosition.x>1.0 && touchPosition.x<4.6 && touchPosition.y>-7.6 && touchPosition.y<-3.6)
            {
                // Debug.DrawLine(fireButton.position, touchPosition, Color.red);
                BuDirecHori = (touchPosition.x - touchMiddle.x) / touchDelta.x;
                BuDirecVerti= (touchPosition.y - touchMiddle.y) / touchDelta.y;
                //Debug.Log("BulletDirection::Horizontal::" + BuDirecHori);
                //Debug.Log("BulletDirection::Vertical::" + BuDirecHori);

            }

        }
    }
}

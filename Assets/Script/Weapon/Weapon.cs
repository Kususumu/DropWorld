using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //this come inside the joystick because the BulletMove could not save orentation
    //public Joystick joyStickBullet;
    //static public float weaponHorizontal;
    //static public float weaponVertical;

    public Transform firePoint;
    public GameObject bulletPrefab;

    //For shoot()to defind what weapon to use
    private int weaponChoose;

    private void Start()
    {
        weaponChoose = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!JerryControl.isPhone)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                shoot(weaponChoose);
            }
        }
    }

    //A Function that divide what kind of weapon to use
    public void shoot(int choose)
    {
        switch (choose)
        {
            case 0:
                originalShoot();
                break;
            case 1:
                break;
            default:
                break;
        }

    }

    public void originalShoot()
    {
        //
        //shooting logic
        //
        //Debug.Log("Weapon::originalShoot()");
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletObject;
    public Transform ShootPoint;

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKeyDown(KeyCode.J))
             {
            var newBullet = Instantiate(bulletObject) as GameObject;
            newBullet.transform.position = ShootPoint.position;
            newBullet.transform.rotation = transform.rotation;



        }
    }
}

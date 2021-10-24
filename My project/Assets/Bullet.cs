using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float movementSpeed;

    private void FixedUpdate()
    {
        rigidbody.velocity = transform.right * movementSpeed * Time.fixedDeltaTime;


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Ork")){
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);




        }

        if (collision.collider.CompareTag("Block"))
        {

            Destroy(gameObject);





        }



    }

}

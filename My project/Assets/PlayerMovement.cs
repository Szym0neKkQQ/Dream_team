using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    public float moveSpeed = 5f;
    float dirX;
    public Rigidbody2D rb;

    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetFloat("moveSpeed", Mathf.Abs(Input.GetAxis("Horizontal")));
        }
        else if (Input.GetAxis("Vertical") != 0)
        {
            animator.SetFloat("moveSpeed", Mathf.Abs(Input.GetAxis("Vertical")));
        }
        else
        {
            animator.SetFloat("moveSpeed", 0f);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }


       

            transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed, 0);
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed *Time.fixedDeltaTime);

    }
}

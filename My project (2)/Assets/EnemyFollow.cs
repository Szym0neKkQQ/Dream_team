using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    [SerializeField] public float attackDamage = 10f;
    [SerializeField] public float attackSpeed = 1f;
    public float canAttack;
    private Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            if (Input.GetAxis("Horizontal") > 0.01f)
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
            }
            else if (Input.GetAxis("Horizontal") < -0.01f)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }


        }

    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (attackSpeed <= canAttack)
            {
                other.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
                canAttack = 0f;
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }
    }



}

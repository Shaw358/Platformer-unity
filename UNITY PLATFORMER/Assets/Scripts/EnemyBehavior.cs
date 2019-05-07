using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    private float speed = 2;
    public float distance;
    public float hp = 10;

    private bool movingRight = true;

    public Transform groundDetection;
    private Transform target;

    private bool playerSeen;


    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {



        if (Vector2.Distance(transform.position, target.position) > 5)
        {


            transform.Translate(Vector3.right * speed * Time.deltaTime);

            RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

            if (groundInfo.collider == false)
            {
                if (movingRight == true)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                    movingRight = false;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingRight = true;
                }
            }
        }
        else if(Vector2.Distance(transform.position, target.position) < 5 )
        {
            transform.LookAt(target.position);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0)); ;
        }
    }

    public void TakeDamage (int damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }



}

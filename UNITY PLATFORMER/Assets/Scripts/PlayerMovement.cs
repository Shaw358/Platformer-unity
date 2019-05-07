using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject bullet;
    public GameObject viper;

    private Rigidbody2D myRigidbody;
    private float speed = 15;
    private bool facingRight;
    private bool ground = false;
    private float jump = 23;
    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Movement(horizontal);
        Flip(horizontal);
        if (Input.GetKey("w"))
        {
            if (ground)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            }
        }
        if(facingRight == false)
        {
            bullet.GetComponent<bullet>().left = true;
        }
        if (facingRight == true)
        {
            bullet.GetComponent<bullet>().left = false;
        }
    }

    void OnTriggerEnter2D()
    {
        ground = true;
    }

    void OnTriggerExit2D()
    {
        ground = false;
    }

    private void Movement(float horizontal)
    {

        myRigidbody.velocity = new Vector2(horizontal * speed,myRigidbody.velocity.y);
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "cylon")
        {
            SceneManager.LoadScene("dead");
        }
        if (coll.gameObject.tag == "chip")
        {
            Destroy(GameObject.FindWithTag("chip"));
        }



    }


}

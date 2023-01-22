using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BIKE : MonoBehaviour
{
    public GameObject gameManager;

    public float speed;
    Rigidbody2D rb;

    AudioSource sfx;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        
        if(Input.GetKey(KeyCode.J))
        {
            speed--;
        }
        if(Input.GetKey(KeyCode.K))
        {
            speed++;
        }
        

    }

    private void FixedUpdate()
    {
        rb.velocity = Vector3.right * speed * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        GAMEMANAGER gm = gameManager.GetComponent<GAMEMANAGER>();

        if (collision.collider.tag == "YESMAN")
        {
            gm.Win();

            sfx.Play();

            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }

        if(collision.collider.tag =="GOAL")
        {
            gm.Lose();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.name == "CHECK1")
        {
            speed = 100;
        }
        if(collision.name == "CHECK2")
        {
            speed = 300;
        }

       
    }
}

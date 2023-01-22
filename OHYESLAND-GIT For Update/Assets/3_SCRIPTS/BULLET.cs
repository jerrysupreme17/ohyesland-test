using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BULLET : MonoBehaviour
{
    public float power;
    public float speed;
    public Rigidbody2D rb;


    Rigidbody2D rollrb;

    GameObject gm;


    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector3.up * speed);

        gm = GameObject.FindGameObjectWithTag("GAMEMANAGER");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        BALLONS ballons = hitInfo.GetComponent<BALLONS>();
        GAMEMANAGER GM = gm.GetComponent<GAMEMANAGER>();
        MRNO mrno = hitInfo.GetComponent<MRNO>();

        rollrb = hitInfo.GetComponent<Rigidbody2D>();


        // Debug.Log(hitInfo.name);

        if (hitInfo.tag == "BALLONS" && ballons != null)
        {
            //Destroy(hitInfo.gameObject);
            ballons.Die();
        }

        if(hitInfo.tag =="MRNO")
        {
            mrno.Hurt();
        }

        if(hitInfo.tag =="GHOST")
        {
            //Destroy(hitInfo.gameObject);
        }

        if(hitInfo.tag == "SUSHI")
        {
           // rollrb.AddForce(Vector2.right * power);
            
            //ballons.Die();
        }

 

        Destroy(gameObject);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rollrb = collision.collider.GetComponent<Rigidbody2D>();
        
        if(collision.collider.tag =="WALL" || collision.collider.tag =="BALLONS")
        {
            Destroy(gameObject);
        }

        if(collision.collider.tag =="SUSHI")
        {
            rollrb.AddForce(Vector2.up* power);

            Destroy(gameObject);

            Debug.Log("hit sushi!");
        }
    }
}

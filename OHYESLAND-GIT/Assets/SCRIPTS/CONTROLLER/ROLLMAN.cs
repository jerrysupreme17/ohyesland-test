using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROLLMAN : MonoBehaviour
{

    Rigidbody2D rb;

    bool canJump = true;

    public float speed;

    public float jumpSpeed = 300;

    private GameObject currentTeleporter;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(- Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector3.up * jumpSpeed * Time.deltaTime);

            canJump = false;


        }
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        { 
        if(currentTeleporter != null)
        {
            transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
        }
    }
}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "FLOOR")
        {
            canJump = true;
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("TP"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("TP"))
        {
            if(collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }

}

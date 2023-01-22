using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROLLMAN_2 : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public float jumpforce;

    private bool isGrounded;

    public int extraJumps;

    AudioSource jumpsfx;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpsfx = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && extraJumps > 0)
        {
            jumpsfx.Play();

            if (extraJumps == 2)
            {
                jumpforce = 8;
            }
            else jumpforce = 4;
            rb.velocity = rb.velocity += Vector2.up * jumpforce;
            extraJumps--;
        }
    }

    private void FixedUpdate()
    {

        float HAxis = Input.GetAxis("Horizontal");
        rb.AddForce(1f * HAxis * Vector3.right * speed * Time.deltaTime);



    }

    
    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "FLOOR")
        {
            extraJumps = 2;
        }


    }


}

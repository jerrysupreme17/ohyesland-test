using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NCONTROL : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * speed,ForceMode2D.Impulse);
            //transform.Translate(Vector3.up * speed, Space.World);
            //rb.velocity = transform.up * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.up * speed,ForceMode2D.Impulse);
            //transform.Translate(Vector3.down * speed, Space.World);
            //rb.velocity = - transform.up * speed;


        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed, ForceMode2D.Impulse);
            //transform.Translate(Vector3.left * speed, Space.World);
            //rb.velocity =  -transform.right * speed;


        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
            //transform.Translate(Vector3.right * speed, Space.World);
            //rb.velocity = transform.right * speed;


        }

    }
}

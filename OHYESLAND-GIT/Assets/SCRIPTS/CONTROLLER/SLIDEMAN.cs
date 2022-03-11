using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLIDEMAN : MonoBehaviour
{

    Rigidbody2D rb;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude <=3)
        {



            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = Vector3.up * speed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = Vector3.down * speed;
            }

            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = Vector3.left * speed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = Vector3.right * speed;
            }


        }



    }
}

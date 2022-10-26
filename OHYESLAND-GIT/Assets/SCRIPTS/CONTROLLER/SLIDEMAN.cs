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

        float HAxis = Input.GetAxis("Horizontal");
        float VAxis = Input.GetAxis("Vertical");

        if (rb.velocity.magnitude <=3)
        {

            //新版
            if(HAxis >= 0.9f || HAxis <=-0.9f)
            {
                rb.velocity = Vector3.right * speed * HAxis;
            }

            if (VAxis >= 0.9f || VAxis <= -0.9f)
            {
                rb.velocity = Vector3.up * speed * VAxis;

            }


            
            //原版上下左右操作
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = Vector3.up * speed;
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                rb.velocity = Vector3.down * speed;
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = Vector3.left * speed;
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = Vector3.right * speed;
            }
            



        }



    }
}

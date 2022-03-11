using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WATERBALL : MonoBehaviour
{

    Rigidbody2D rb;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(Random.Range(-speed, speed), Random.Range(speed, -speed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

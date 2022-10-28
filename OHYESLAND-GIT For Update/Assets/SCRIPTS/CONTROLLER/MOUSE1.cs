using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOUSE1 : MonoBehaviour
{


    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    public PointEffector2D pointEffector;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pointEffector = GetComponent <PointEffector2D >();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pointEffector.forceMagnitude);


        MoveTrans();

        if (Input.GetMouseButton(0))
        {
            pointEffector.forceMagnitude = 30f;

        }
        else pointEffector.forceMagnitude = 0f;
    }

    void MoveTrans()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }


    private void FixedUpdate()
    {
        //MoveRigid();
    }
    void MoveRigid()
    {

        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        rb.velocity = (mousePosition = transform.position) * moveSpeed;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}

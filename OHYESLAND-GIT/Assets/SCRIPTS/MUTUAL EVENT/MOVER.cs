using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVER : MonoBehaviour
{

    public float x_speed;
    public float y_speed;

    public Transform yesman;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //transform.Translate(x_speed * Time.deltaTime, y_speed * Time.deltaTime, 0);

        transform.position = new Vector3(yesman.position.x, transform.position.y, transform.position.z);
    }
}

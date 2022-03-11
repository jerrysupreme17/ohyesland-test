using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHOOTER : MonoBehaviour
{
    public float movespeed;

    public float offset;

    public Transform firePoint;

    public GameObject bullet;

    public GameObject FX;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movespeed * Time.deltaTime); 
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        }


        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullet, firePoint.position,firePoint.rotation);
            Instantiate(FX, new Vector2(firePoint.position.x,firePoint.position.y+ offset), firePoint.rotation);
        }

    }
}

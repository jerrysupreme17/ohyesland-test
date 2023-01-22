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

    public GameObject yeser;

    public float cdtime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float HAxis = Input.GetAxis("Horizontal");

        cdtime -= Time.deltaTime;


        transform.Translate(Vector3.right * movespeed * Time.deltaTime * HAxis);
        



        //ÂÂª©
        /*
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movespeed * Time.deltaTime); 
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        }
        */

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)  || Input.GetKeyDown(KeyCode.Joystick1Button1) ) 
        {

            Instantiate(bullet, firePoint.position,firePoint.rotation);
            Instantiate(FX, new Vector2(firePoint.position.x,firePoint.position.y+ offset), firePoint.rotation);
        }

        if(Input.GetMouseButtonDown(1) ||Input.GetKeyDown(KeyCode.Joystick1Button2)) 
        {
            if (cdtime <= 0)
            {
                Instantiate(yeser, firePoint.position + new Vector3(0, 3, 0), firePoint.rotation);
                Instantiate(FX, new Vector2(firePoint.position.x, firePoint.position.y + offset), firePoint.rotation);
                cdtime = 1;
            }

        }

    }
}

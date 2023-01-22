using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LASERMAN : MonoBehaviour
{
    public float movespeed;

    public Transform firePoint;

    public GameObject bullet;


    public AudioSource laserSFX;
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


        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(bullet, firePoint.position, firePoint.rotation);

            if(!laserSFX.isPlaying)
            {
                laserSFX.Play();
            }
        }

    }
}

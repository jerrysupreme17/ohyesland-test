using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pate : MonoBehaviour
{

    public Rigidbody2D steakrb;

    public float power;

    AudioSource sfx;

    public AudioSource sfx2;

    public AudioSource sfx3;
    public AudioSource sfx4;
    public AudioSource sfx5;

    

    bool hasHit = false;

    // Start is called before the first frame update
    void Start()
    {
        sfx = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "YESMAN" && hasHit == false)
        {
            steakrb.AddForce(Vector3.up * power);
            sfx.Play();
            sfx2.Play();
            hasHit = true;
            StartCoroutine(Play3moreSound());
        }
    }

    IEnumerator Play3moreSound ()
    {


        yield return new WaitForSeconds(0.1f);

        sfx3.Play();

        yield return new WaitForSeconds(0.1f);

        sfx4.Play();

        yield return new WaitForSeconds(0.1f);

        sfx5.Play();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOCCER : MonoBehaviour
{
    public GameObject gameManager;

    public float waitTime;

    public float speed;

    public AudioSource SFX;

    public bool canKick = false;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        waitTime = Random.Range(4, 7);

        SFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();


        if (GM.yes >= 5)
        {
            rb.velocity = new Vector2(0, 0);
        }

        waitTime -= Time.deltaTime;

        if(waitTime <=0f && waitTime >=-0.2f)
        {
            canKick = true;

        }

        if(canKick)
        {

            Kick();
            //SFX.Play();
            canKick = false;
        }

    }


    public void Kick()
    {
        rb.AddForce(Vector3.right * speed *Time.deltaTime);
        if (!SFX.isPlaying)
        {
            SFX.Play();

        }
        canKick = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if (collision.tag == "GOAL")
        {
            GM.Lose();
            //rb.velocity = new Vector2(0, 0);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if (collision.collider.tag == "YESMAN")
        {
            GM.Win();

            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}

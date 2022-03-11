using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOUNCEBALL : MonoBehaviour
{

    public GameObject gameManager;

    AudioSource SFX;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        SFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();


        if (GM.yes >=5)
        {
            rb.velocity = new Vector2(10, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if(collision.tag == "GOAL")
        {
            GM.Win();
            SFX.Play();
            //rb.velocity = new Vector2(0, 0);
            
        }

    }

    
}

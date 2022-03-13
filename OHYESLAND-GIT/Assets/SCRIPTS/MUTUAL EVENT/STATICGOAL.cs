using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STATICGOAL : MonoBehaviour
{

    public GameObject gameManager;

    AudioSource SFX1;

    public float stayTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        SFX1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if (collision.tag == "YESER")
        {
            GM.Win();
        }

        if (collision.tag == "BULLET")
        {
            GM.Complete();
            
                SFX1.Play();
            
        }

        if(collision.tag == "CABLE")
        {
            Debug.Log("I an in!");
            GM.Win();
        }

        if(collision.tag == "YESMAN")
        {
            GM.yes += 0.5f;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if(collision.tag == "CABLE")
        {
            stayTimer += Time.deltaTime;

        }

        if(collision.tag == "BULLET")
        {
            GM.Win();
            SFX1.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "CABLE")
        {
            stayTimer = 0;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if (collision.collider.tag =="BULLET" || collision.collider.tag == "YESMAN")
        {
            GM.Win();
            SFX1.Play();
        }

        if (collision.collider.tag =="YESMANSQUARE")
        {
            GM.yes += 0.5f;
            SFX1.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STATICLOSE : MonoBehaviour
{

    public GameObject gameManager;

    AudioSource SFX1;



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



        if (collision.tag == "BULLET")
        {
            GM.Lose();
            
                SFX1.Play();
            
        }



    }




}

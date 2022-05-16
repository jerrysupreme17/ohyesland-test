using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class GHOST_BIG : MonoBehaviour
{

    GameObject gm;
    Animator animator;
    bool isKilled =false;
    AudioSource sfx1;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindWithTag("GAMEMANAGER");
        animator = GetComponent<Animator>();
        sfx1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GAMEMANAGER gameManager= gm.GetComponent<GAMEMANAGER>();

        animator.SetBool("ISKILLED", isKilled);

        if (gameManager.yes >=5)
        {
            isKilled = true;

            if(!sfx1.isPlaying)
            {
                sfx1.Play();
                
            }

        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ANI_TRIGGER : MonoBehaviour
{
    Animator animator;

    AudioSource audioSource;

    public AudioSource sfx1;


    public bool IsTrigger;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("ISPUSHED", IsTrigger);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "YESMAN")
        {
            IsTrigger = true;

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TRIGGER1")
        {
            if (!sfx1.isPlaying)
            {
                sfx1.Play();
            }
        }


    }
}

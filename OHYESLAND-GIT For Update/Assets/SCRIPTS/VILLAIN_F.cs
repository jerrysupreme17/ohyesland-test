using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VILLAIN_F : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;
    AudioSource audioSource;
    bool ishit;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("HIT", ishit);
        Debug.Log(ishit);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="YESMAN")
        {
            ishit = true;
            if(!audioSource.isPlaying)
            {
                audioSource.Play();

            }
        }
    }
}

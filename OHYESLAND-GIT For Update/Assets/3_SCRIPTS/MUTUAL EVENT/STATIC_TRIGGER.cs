using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STATIC_TRIGGER : MonoBehaviour
{

    //public Animator animator;
    public GameObject Trigger_object1;

    bool isTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("ISTRIGGER", isTrigger);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "YESER")
        {
            Trigger_object1.SetActive(true);
        }
    }
}

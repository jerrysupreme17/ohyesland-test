using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPRINT : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D RB_yesman;

    AudioSource SFX1;
    // Start is called before the first frame update

    private void Start()
    {
        SFX1 = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag =="YESMAN")
        {
            RB_yesman.AddForce(Vector2.up * Time.deltaTime * speed);
            SFX1.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Localization.Plugins.XLIFF.V20;
using UnityEngine;

public class HIT_TARGET : MonoBehaviour
{

    public GameObject gameManager;

    public float speed = 5f;
    public bool isHit = false;
    public const string layer_name = "TOP";

    public float wait_time;

    int hp = 3;
    SpriteRenderer sprite;

    AudioSource SFX1;

    public AudioSource SFX2;
    // Start is called before the first frame update
    void Start()
    {
        SFX1 = GetComponent<AudioSource>();
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(isHit == true)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            transform.parent = null;
        }

    }


    //trigger¦Cªí
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();
        Rigidbody2D TargetRB = collision.gameObject.GetComponent<Rigidbody2D>();

        Rigidbody2D selfRB = gameObject.GetComponent<Rigidbody2D>();

        if(collision.tag == "BULLET" && gameObject.tag =="APPLE")
        {
            SFX1.Play();
            isHit = true;
            //sprite.sortingLayerName = layer_name;
            sprite.sortingLayerName = "TOP";
        }

        if(collision.tag == "BULLET" && gameObject.tag == "BOMB")
        {
            SFX1.Play();
            GM.Lose();
        }

        if(collision.tag =="BULLET" && gameObject.tag == "NORMAL")
        {
            SFX1.Play();
        }

        if(collision.tag == "YESER" && gameObject.tag == "SUSHI")
        {
            SFX1.Play();
            GM.yes += 1.25F;
            selfRB.AddForce(Vector3.right * 400);
        }


        if(collision.tag =="YESMAN")
        {
            GM.Lose();
        }

        

        if(collision.tag =="BULLET" && gameObject.tag =="GHOST")
        {
            hp -= 1;
            if(SFX2 != null)
            {
                SFX2.Play();

            }

            if(hp == 2)
            {
                GetComponent<SpriteRenderer>().color = new Color32(180, 180, 180, 180);

            }

            if(hp ==1)
            {
                GetComponent<SpriteRenderer>().color = new Color32(100, 100, 100, 180);

            }
            if (hp <= 0)
            {
                this.gameObject.SetActive(false);
            }
            //this.sprite.enabled = false;
            GM.yes += 0.167f;
        }

        

    }


    //collision¦Cªí
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if (collision.collider.tag=="STEAK")
        {
            StartCoroutine(Win());
        }
    }

    IEnumerator Win()
    {
        GAMEMANAGER gm = gameManager.GetComponent<GAMEMANAGER>();


        yield return new WaitForSeconds(wait_time);

        gm.Win();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIT_TARGET : MonoBehaviour
{

    public GameObject gameManager;

    public float speed = 5f;
    public bool isHit = false;
    public const string layer_name = "TOP";

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

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


}

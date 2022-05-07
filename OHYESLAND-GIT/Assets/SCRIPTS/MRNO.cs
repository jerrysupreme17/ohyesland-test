using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRNO : MonoBehaviour
{
    GameObject gameManager;


    public float speed = 5f;

    public float big_speed = 0f;
    public AudioSource SFX;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GAMEMANAGER");
    }

    // Update is called once per frame
    void Update()
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if(GM.yes >=5)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
            transform.parent = null;
        }


    }

    private void FixedUpdate()
    {

        big_speed += Time.deltaTime;
        if(gameObject.tag =="MRNO_BIG")
        {
            transform.Translate(big_speed * Time.deltaTime, 0,0 );
        }
    }

    public void Hurt()
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();



        SFX.Play();

        //Destroy(this.gameObject);

        GM.yes += 2;

        if (GM.yes >=1 && GM.yes <=4)
        {
            GetComponent<SpriteRenderer>().color = new Color32(180, 180, 180, 255);
        }
        if(GM.yes >=4 )
        {
            GetComponent<SpriteRenderer>().color = new Color32(110, 110, 110, 180);

        }

        //this.gameObject.SetActive(false);




    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if (gameObject.tag == "MRNO_BIG" && collision.tag == "YESER")

        {
            GM.Lose();
        }

        SFX.Play();
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRNO : MonoBehaviour
{
    GameObject gameManager;



    public AudioSource SFX;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GAMEMANAGER");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hurt()
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();



        SFX.Play();

        //Destroy(this.gameObject);


        //this.gameObject.SetActive(false);

        GM.Complete();
        GM.Complete();


    }
}

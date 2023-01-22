using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALLONS : MonoBehaviour
{
    GameObject gameManager;

    public GameObject FX;

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

    public void Die()
    {
        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        Instantiate(FX, transform.position, transform.rotation);

        SFX.Play();

        //Destroy(this.gameObject);


        this.gameObject.SetActive(false);
        
        GM.Complete();
    }


}

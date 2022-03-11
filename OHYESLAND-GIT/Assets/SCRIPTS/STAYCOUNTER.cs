using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STAYCOUNTER : MonoBehaviour
{
    // Start is called before the first frame update

    public int stayCount;

    public int stayLimit;

    public GameObject gameManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GAMEMANAGER gm = gameManager.GetComponent<GAMEMANAGER>();

        if (stayCount >= stayLimit)
        {
            gm.Win();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "WATERBALL")
        {

            stayCount++;
        }

    }

}

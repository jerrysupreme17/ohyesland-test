using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEAWAVE : MonoBehaviour
{
    public GameObject gameManager;

    public float timeNow = 0f;
    public float WinTime = 12.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        timeNow += Time.deltaTime;

        if(timeNow >= WinTime && GM.yes >=0)
        {
            GM.Win();
        }
    }
}

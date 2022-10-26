using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S_CONTROLL : MonoBehaviour
{

    public GameObject gameManager;
    public GameObject trans_Canvas;

    public float speed;
    AudioSource sfx1;
    public int now_cut = 0;
    public int limit_cut = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        sfx1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RectTransform a = this.transform as RectTransform;
        GAMEMANAGER gm = gameManager.GetComponent<GAMEMANAGER>();
        LEVEL_LOADER level_loader = trans_Canvas.GetComponent<LEVEL_LOADER>();

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            //transform.Translate(new Vector2(-300, 0),Space.World);
            sfx1.Play();

            //a.Translate(new Vector2(-300, 0));
            a.anchoredPosition = a.anchoredPosition + new Vector2(-1500, 0);

            now_cut += 1;
            
        }

        if(now_cut > limit_cut)
        {
            level_loader.LoadNextLevel();
        }

        

    }

}

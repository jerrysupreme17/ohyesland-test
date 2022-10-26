using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YESWORD : MonoBehaviour
{

    Animator animator;
    AudioSource audioSource;
    public int hit;
    public int goal_hit = 15;

    public GameObject sword_self;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        GAMEMANAGER gm = gameManager.GetComponent<GAMEMANAGER>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("GOAL", hit);

        if(Input.GetKeyDown(KeyCode.Space) && hit <21)
        {
            hit += 1;
            sword_self.transform.localScale = sword_self.transform.localScale * 1.04f;
            audioSource.Play();

            StartCoroutine(Win());
        }


        if (Input.GetKeyDown(KeyCode.Joystick1Button1) && hit < 21)
        {
            hit += 1;
            sword_self.transform.localScale = sword_self.transform.localScale * 1.04f;
            audioSource.Play();

            StartCoroutine(Win());
        }

    }

    IEnumerator Win()
    {
        GAMEMANAGER gm = gameManager.GetComponent<GAMEMANAGER>();


        yield return new WaitForSeconds(8.3f);

        gm.Win();
    }
}

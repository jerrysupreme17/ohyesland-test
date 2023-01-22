using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TOTALSCORE : MonoBehaviour
{

    float allscore;

    GameObject gameManager;

    public Animator animator;

    bool ani_show= false;

    TextMeshProUGUI totalScore;


    bool plus = false;

    private void Start()
    {
        //animator.SetBool("IsShow", ani_show);

        allscore = STATIC_SCORE.allScore;


    }

    private void Update()
    {

        showTheScore();

        animator.SetBool("IsShow", ani_show);

        //Debug.Log(allscore);
    }

    void showTheScore()
    {
        gameManager = GameObject.FindGameObjectWithTag("GAMEMANAGER");

        GAMEMANAGER gm = gameManager.GetComponent<GAMEMANAGER>();

        SCORES score = gameManager.GetComponent<SCORES>();

        totalScore = GameObject.FindGameObjectWithTag("TOTALSCORE").GetComponent<TextMeshProUGUI>();

        if (gm.yes >=5 && plus == false)
        {

            ani_show = true;

            float LevelScore = score.currentTime * 1000f;

            allscore += LevelScore;


            totalScore.text = allscore.ToString("0");

            STATIC_SCORE.allScore = allscore;

            plus = true;
            
        }
    }




}
